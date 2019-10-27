using CoffeeMug.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMug.Infrastructure.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void InitialSeed(this ModelBuilder modelBuilder)
            => modelBuilder.Entity<Product>().HasData(
               new Product(Guid.NewGuid(), "Audi A4", 149000.99m),
               new Product(Guid.NewGuid(), "BMW M5", 399000.95m),
               new Product(Guid.NewGuid(), "Mercedes GLC", 179000),
               new Product(Guid.NewGuid(), "Mazda 6", 119000),
               new Product(Guid.NewGuid(), "Opel Astra", 79000),
               new Product(Guid.NewGuid(), "Seat Ateca", 150000),
               new Product(Guid.NewGuid(), "Skoda Superb", 159000),
               new Product(Guid.NewGuid(), "Saab 9-3", 15800),
               new Product(Guid.NewGuid(), "Volkswagen Amarok", 180000),
               new Product(Guid.NewGuid(), "Volvo S60", 219000)
           );
    }
}
