
using Microsoft.EntityFrameworkCore;
using production.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace production
{
    internal class ApplicationDbContext :DbContext
    {
        public DbSet<Customer> customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=BikeStoresEF;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().ToTable("ActualCustomers");

            modelBuilder.Entity<Customer>().Property(e => e.Email).HasMaxLength(50);

            modelBuilder.Entity<Customer>().Property(e => e.Phone).HasColumnName("PhoneNumber");

            //modelBuilder.Entity<Customer>().Property(e => e.FullName).HasComputedColumnSql("FirstName +' '+ LastName ");

            modelBuilder.Entity<Customer>().Property(e => e.Created).HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Category>().HasMany(e => e.Products).WithOne(e => e.Category).HasForeignKey(e => e.CategoryID);

            modelBuilder.Entity<Product>().HasOne(e => e.brand).WithMany(e => e.Products).HasForeignKey(e=>e.BrandID);

            modelBuilder.Entity<Customer>().HasIndex(e => new { e.FirstName,e.LastName });

            modelBuilder.HasSequence<int>("indexCounter");

            modelBuilder.Entity<Customer>().Property(e => e.Counter).HasDefaultValueSql("Next Value For indexCounter");

        }
    }
}
