using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Market
{
    public class Context:DbContext
    {
        public DbSet<Stor> Stors { get; set; }
        public DbSet<Categorys> Categorys { get; set; }
         public DbSet<Proudect> proudcts { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<Recipt> recipts { get; set; }
        public DbSet<Sellinvoce> sellinvoces { get; set; }
        public DbSet<Suppliers> suppliers { get; set; }
       


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data source=DESKTOP-NNJMDGE\SQL19; initial catalog = Super_Markett;Integrated Security=True; trust server certificate = true");
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasData(new Users
            {
                Salary= 1000,
                UserName="sasa",
                Password=2555,
                Pos= 0,
                

            });

        }
    }
}
