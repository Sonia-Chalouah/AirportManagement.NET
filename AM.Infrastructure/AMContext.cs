using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
namespace AM.Infrastructure
{
    public class AMContext : DbContext
    {
        public DbSet <Plane> Planes { get; set; }
        public DbSet<Flight> Flights{ get; set; }
        public DbSet<Passenger> Passengers { get; set; }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Traveller> Travellers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AirportMgmtDb;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);

        }
    }
}
