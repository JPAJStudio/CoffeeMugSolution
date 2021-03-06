﻿// <auto-generated />
using System;
using CoffeeMug.Infrastructure.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoffeeMug.Api.Migrations
{
    [DbContext(typeof(MyDatabaseContext))]
    partial class MyDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoffeeMug.Core.Domain.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cfd2e301-17e5-48a3-a6da-ea35fcc68647"),
                            Name = "Audi A4",
                            Price = 149000.99m
                        },
                        new
                        {
                            Id = new Guid("ae38790b-4616-46db-b95b-95fe3222f9b6"),
                            Name = "BMW M5",
                            Price = 399000.95m
                        },
                        new
                        {
                            Id = new Guid("ec6f9796-e2c8-4227-9593-6e77dbbc1319"),
                            Name = "Mercedes GLC",
                            Price = 179000m
                        },
                        new
                        {
                            Id = new Guid("d2a898ee-b54b-4c3c-ab30-1d687fd1abbc"),
                            Name = "Mazda 6",
                            Price = 119000m
                        },
                        new
                        {
                            Id = new Guid("7739b7e0-92a5-44d7-b722-719c7355e0dc"),
                            Name = "Opel Astra",
                            Price = 79000m
                        },
                        new
                        {
                            Id = new Guid("3fbdb1e8-3bc3-4eca-9d20-617296831cd7"),
                            Name = "Seat Ateca",
                            Price = 150000m
                        },
                        new
                        {
                            Id = new Guid("f5d0177d-1ade-4c91-8c45-f955969c9d09"),
                            Name = "Skoda Superb",
                            Price = 159000m
                        },
                        new
                        {
                            Id = new Guid("e21c9d1a-3e99-48b9-a738-ae620f8f6729"),
                            Name = "Saab 9-3",
                            Price = 15800m
                        },
                        new
                        {
                            Id = new Guid("ab403513-e911-4c2d-bac0-365eeb09bb90"),
                            Name = "Volkswagen Amarok",
                            Price = 180000m
                        },
                        new
                        {
                            Id = new Guid("b997d0c6-28c7-40f6-b0a2-266cbab5560d"),
                            Name = "Volvo S60",
                            Price = 219000m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
