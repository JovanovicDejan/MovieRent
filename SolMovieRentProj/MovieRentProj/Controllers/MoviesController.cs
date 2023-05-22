using MovieRentProj.Models;
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
    }
}