using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AppDbContext : DbContext
    {
        private string DbPath { get; set; }

        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "contacts.db");
        }

        public DbSet<ContactEntity> Contacts { get; set; }
        public DbSet<ProductEntity> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)=>
            options.UseSqlite($"Data Source={DbPath}");
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactEntity>().HasData(
                new ContactEntity() { ContactId = 1, Name = "Adam", Email = "adam@wsei.edu.pl", Phone = "127813268163", BirthDate = new DateTime(2000, 10, 10), Priority=1 },
                new ContactEntity() { ContactId = 2, Name = "Ewa", Email = "ewa@wsei.edu.pl", Phone = "293443823478", BirthDate = new DateTime(1999, 8, 10), Priority = 2 }
            );

            modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity() { Id = 1, ProductName="Lamp", Price=99, Producent="Ikea", DateOfProduction= new DateTime(2023, 11, 8, 15, 30, 0), Description= "Lampa sufitowa/ścienna LED, smart bezprzewodowy przyciemniany/ciepły biały biały, 37 cm", Quality=2 }
                );
        }
    }
}
