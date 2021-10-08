using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var user1 = new Employee { Id = 1, LastName = "Stivenson", FirstName = "Stiv", Role = "DEV" };
            var user2 = new Employee { Id = 2, LastName = "Stivenson", FirstName = "Bob", Role = "PM" };
            modelBuilder.Entity<Employee>().HasData(new Employee[] { user1, user2 });
        }
    }
}
