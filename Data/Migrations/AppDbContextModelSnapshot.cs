﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("Data.Entities.ContactEntity", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.HasKey("ContactId");

                    b.ToTable("contacts");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            BirthDate = new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "adam@wsei.edu.pl",
                            Name = "Adam",
                            Phone = "127813268163",
                            Priority = 1
                        },
                        new
                        {
                            ContactId = 2,
                            BirthDate = new DateTime(1999, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ewa@wsei.edu.pl",
                            Name = "Ewa",
                            Phone = "293443823478",
                            Priority = 2
                        });
                });

            modelBuilder.Entity("Data.Entities.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DateOfProduction")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Producent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("Quality")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfProduction = new DateTime(2023, 11, 8, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lampa sufitowa/ścienna LED, smart bezprzewodowy przyciemniany/ciepły biały biały, 37 cm",
                            Price = 99m,
                            Producent = "Ikea",
                            ProductName = "Lamp",
                            Quality = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
