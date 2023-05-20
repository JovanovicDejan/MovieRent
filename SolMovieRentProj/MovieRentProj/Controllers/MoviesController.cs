using MovieRentProj.Models;
using System.Web.Mvc;

namespace MovieRentProj.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek! " };
            return View(movie);
        }
    }
}