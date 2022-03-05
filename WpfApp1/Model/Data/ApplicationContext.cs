using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WpfApp1.Model.UnitDB;

namespace WpfApp1.Model.Data
{
    class ApplicationContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Nutrition> Nutritions { get; set; }
        public DbSet<Staff> Staves { get; set; }
        public DbSet<TourType> TourTypes { get; set; }
        public DbSet<Tour> Tours { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=TravelAgencyDB;Trusted_Connection=True");
        }
    }
}
