﻿using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace MovieRentProj.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Genre> Gener { get; set; }
        public DbSet<Rental> Rental { get; set; }


        public DbSet<MembershipType> MemberShipTypes { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}