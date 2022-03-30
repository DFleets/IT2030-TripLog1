using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace TripLog1.Models
{
    public class TripContext :  DbContext
    {
        public TripContext (DbContextOptions<TripContext> options) : base (options) { }
        
        public DbSet<Trip> Trips { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.Entity<Trip>().HasData(
                
                new Trip
                {
                    TripID = 1,
                    Destination = "Boise",
                   // StartDate =DateTime.Parse("6/6/2020"),
                   // EndDate = DateTime.Parse("6/14/2020"),
                    Accommodations = "",
                    Things = " Visit Tammy",
                    Things1 = "",
                    Things2 = ""
                },

                new Trip
                {
                    TripID = 2,
                    Destination = "Portland",
                   // StartDate = DateTime.Parse("6/6/2020"),
                   // EndDate = DateTime.Parse("6/6/2020"),
                    Accommodations = "The Benson",
                    Phone = "503-555-1234",
                    Email = "staff@bensonhotel.com",
                    Things = "Go to Vodoo Doughnuts",
                    Things1 = "Walk in the rain",
                    Things2 = "Go to Powell's"
                }


                );
        }
       
    }
}
