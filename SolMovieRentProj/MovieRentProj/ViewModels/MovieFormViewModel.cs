using MovieRentProj.Models;
using System.Collections.Generic;

namespace MovieRentProj.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
    }
}