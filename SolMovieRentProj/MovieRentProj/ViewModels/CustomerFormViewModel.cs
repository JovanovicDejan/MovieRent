using MovieRentProj.Models;
using System.Collections.Generic;

namespace MovieRentProj.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}