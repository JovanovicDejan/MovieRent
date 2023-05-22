using MovieRentProj.Models;
using MovieRentProj.ViewModels;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace MovieRentProj.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        // GET: Movie
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }
        public ActionResult New()
        {
            var genreModel = _context.Gener.ToList();
            var viewModel = new MovieFormViewModel
            {
                Genres = genreModel
            };
            return View("MovieForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                _context.Movies.Add(movie);
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            var viewModel = new MovieFormViewModel()
            {
                Movie = movie,
                Genres = _context.Gener.ToList(),
            };
            return View("MovieForm", viewModel);
        }
    }
}