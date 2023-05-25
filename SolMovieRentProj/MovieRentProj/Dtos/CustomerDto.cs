using System;
using System.ComponentModel.DataAnnotations;

namespace MovieRentProj.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }

        //[Min18YearsIfMember]
        public DateTime? DateOfBirth { get; set; }
    }
}