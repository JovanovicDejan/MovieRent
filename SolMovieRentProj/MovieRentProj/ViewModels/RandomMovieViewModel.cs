﻿using MovieRentProj.Models;
using System.Collections.Generic;

namespace MovieRentProj.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}