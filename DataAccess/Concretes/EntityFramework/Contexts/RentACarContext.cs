using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework.Contexts
{
    public class RentACarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RentACarDb;Trusted_Connection=true");
        }

       
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<CarMaintenance> CarMaintenances { get; set; }
        public DbSet<AplicationUser> AplicationUsers { get; set; }
        public DbSet<CorporateCustomer> CorporateCustomers { get; set; }
        public DbSet<IndividualCustomer> IndividualCustomers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Car>().HasOne(p => p.Brand).WithMany(b => b.Cars).HasForeignKey(p => p.BrandId);
            modelBuilder.Entity<Car>().HasOne(p => p.Color).WithMany(b => b.Cars).HasForeignKey(p => p.ColorId);
            modelBuilder.Entity<CarMaintenance>().HasOne(p => p.Car).WithMany(b => b.CarMaintenances).HasForeignKey(p => p.CarId);    
            modelBuilder.Entity<IndividualCustomer>().HasOne(p => p.AplicationUser).WithMany(b => b.IndividualCustomers).HasForeignKey(p => p.UserId);     
            modelBuilder.Entity<CorporateCustomer>().HasOne(p => p.AplicationUser).WithMany(b => b.CorporateCustomers).HasForeignKey(p => p.UserId);
        }
    }
}
