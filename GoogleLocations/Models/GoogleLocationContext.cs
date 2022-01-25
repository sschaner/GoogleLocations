using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GoogleLocations.Models
{
    public class GoogleLocationContext : DbContext
    {
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GoogleLocations;Trusted_Connection=True;");
        }
    }
}
