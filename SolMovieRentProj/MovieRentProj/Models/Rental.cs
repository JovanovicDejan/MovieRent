using System;
using System.ComponentModel.DataAnnotations;

namespace MovieRentProj.Models
{
    public class Rental
    {
        public int Id { get; set; }

        [Required]
        public Customer Customer { get; set; }
        [Required]
        public Movie Movie { get; set; }
        [Required]
        public DateTime DateRented { get; set; }
        public DateTime? DateReturned { get; set; }
    }
}