using Data.Entities;
using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        private string DbPath { get; set; }

        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "databaseProduct.db");
        }

        public DbSet<ContactEntity> Contacts { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<OrganizationEntity> Organization { get; set; }
        public DbSet<ProducentEntity> Producent { get; set; }
        public DbSet<CountryEntity> Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)=>
            options.UseSqlite($"Data Source={DbPath}");
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var adminRole = new IdentityRole()
                { Name = "admin", NormalizedName ="ADMIN", Id = Guid.NewGuid().ToString()};
            adminRole.ConcurrencyStamp = adminRole.Id;
            
            var userRole = new IdentityRole
                { Name = "user", NormalizedName = "USER", Id = Guid.NewGuid().ToString() };
            userRole.ConcurrencyStamp = userRole.Id;
            
            modelBuilder.Entity<IdentityRole>()
                .HasData(adminRole, userRole);

            PasswordHasher<IdentityUser> passwordHasher = new PasswordHasher<IdentityUser>();

            var admin = new IdentityUser()
                { Id = Guid.NewGuid().ToString(), UserName = "justyna", NormalizedUserName = "JUSTYNA", Email = "justyna.malinowska2001@op.pl", NormalizedEmail = "JUSTYNA.MALINOWSKA2001@OP.PL", EmailConfirmed = true };
            admin.PasswordHash = passwordHasher.HashPassword(admin, "123ABC!@#");
            modelBuilder.Entity<IdentityUser>()
                .HasData(admin);
            
            var user = new IdentityUser()
                { Id = Guid.NewGuid().ToString(), UserName = "marek", NormalizedUserName = "MAREK", Email = "marek@wsei.pl", NormalizedEmail = "MAREK@WSEI.PL", EmailConfirmed = true };
            user.PasswordHash =passwordHasher.HashPassword(user, "123ABC!@#");
            modelBuilder.Entity<IdentityUser>()
                .HasData(user);
            
            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasData(
                    new IdentityUserRole<string>() { RoleId = adminRole.Id, UserId = admin.Id },
                    new IdentityUserRole<string>() { RoleId = userRole.Id, UserId = user.Id }
                );
            
            modelBuilder.Entity<ContactEntity>()
                .HasOne(c => c.Organization)
                .WithMany(o => o.Contacts)
                .HasForeignKey(c => c.OrganizationId);

            modelBuilder.Entity<OrganizationEntity>().HasData(
                new OrganizationEntity() { Id=1, Name="WSEI", Description="Uczelnia wyższa", },
                new OrganizationEntity() { Id=2, Name="PKP", Description="Przewoźnik kolejowy"}
                );
            modelBuilder.Entity<OrganizationEntity>()
                .OwnsOne(o => o.Address)
                .HasData(
                    new { OrganizationEntityId = 1, City = "Kraków", Street = "św. Filipa 17", PostalCode = "31-150" },
                    new { OrganizationEntityId = 2, City = "Kraków", Street = "Pawia 5", PostalCode = "33-050" }
                );

            modelBuilder.Entity<ContactEntity>().HasData(
                new ContactEntity() { ContactId = 1, Name = "Adam", Email = "adam@wsei.edu.pl", Phone = "127813268163", BirthDate = new DateTime(2000, 10, 10), Priority=1, OrganizationId= 1 },
                new ContactEntity() { ContactId = 2, Name = "Ewa", Email = "ewa@wsei.edu.pl", Phone = "293443823478", BirthDate = new DateTime(1999, 8, 10), Priority = 2, OrganizationId=2 }
            );
            
            modelBuilder.Entity<ProducentEntity>()
                .HasOne(p => p.Country)
                .WithMany(c => c.Producents)
                .HasForeignKey(p => p.CountryId);

            modelBuilder.Entity<ProductEntity>()
                .HasOne(c => c.Producent)
                .WithMany(o => o.Products)
                .HasForeignKey(c => c.ProducentId);
            
            modelBuilder.Entity<CountryEntity>()
                .HasData(
                    new CountryEntity(){ Id = 1, Name = "Poland" },
                    new CountryEntity(){ Id = 2, Name = "Spain" },
                    new CountryEntity() { Id = 3, Name = "Finland" },
                    new CountryEntity(){ Id = 4, Name = "France" },
                    new CountryEntity(){ Id = 5, Name = "Sweden" }
                    
                );
            
            modelBuilder.Entity<ProducentEntity>().HasData(
                new ProducentEntity() { Id = 1, Name = "IKEA", Description = "Szwedzka sieć sklepów meblowych.", CountryId = 2 },
                new ProducentEntity() { Id = 2, Name = "JYSK", Description = "Sieć sklepów dekoracyjnych.", CountryId = 3 },
                new ProducentEntity() { Id = 3, Name = "Agata-meble", Description = "Salon mebli oraz artykułów wyposażenia wnętrz.", CountryId = 4 },
                new ProducentEntity() { Id = 4, Name = "Castorama", Description = "Sieć sklepów budowlanych.", CountryId = 1 }
            );
            
            modelBuilder.Entity<ProducentEntity>()
                .OwnsOne(e => e.Location)
                .HasData(
                    new { ProducentEntityId = 1, City = "Warszawa", Street = "Lipowa 12", PostalCode = "39-020" },
                    new { ProducentEntityId = 2, City = "Katowice", Street = "Siewna 5", PostalCode = "23-350" });

            modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity() { Id = 1, ProductName = "Lamp", Price=99, DateOfProduction= new DateTime(2023, 11, 8, 5, 30, 0), Description= "Lampa sufitowa/ścienna LED", Quality=2, ProducentId = 1, IsFavourite = false },
                new ProductEntity() { Id = 2, ProductName = "Table", Price = 199, DateOfProduction = new DateTime(2022, 5, 2, 9, 45, 0), Description = "Stół z sosnowego drewna", Quality = 4, ProducentId = 2, IsFavourite = true },
                new ProductEntity() { Id = 3, ProductName = "Rug", Price = 339, DateOfProduction = new DateTime(2023, 1, 28, 9, 5, 0), Description = "Wzorzysty dywan", Quality = 2, ProducentId = 3, IsFavourite = false },
                new ProductEntity() { Id = 4, ProductName = "Chair", Price = 100, DateOfProduction = new DateTime(2022, 1, 3, 2, 30, 0), Description = "Krzesło do jadalni", Quality = 3, ProducentId = 4, IsFavourite = true },
                new ProductEntity() { Id = 5, ProductName = "Sofa", Price = 1889, DateOfProduction = new DateTime(2023, 12, 24, 2, 10, 0), Description = "Wygodna rozkładana sofa", Quality = 2, ProducentId = 1, IsFavourite = true},
                new ProductEntity() { Id = 6, ProductName = "Plant", Price = 39, DateOfProduction = new DateTime(2021, 9, 16, 7, 0, 0), Description = "Monstera", Quality = 2, ProducentId = 2, IsFavourite = true }
                );



        }
    }
}
