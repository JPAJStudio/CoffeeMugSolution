using CoffeeMug.Core.Domain;
using CoffeeMug.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMug.Infrastructure.DAL
{
    public class MyDatabaseContext : DbContext
    {
		int a = 0;
        public MyDatabaseContext(DbContextOptions<MyDatabaseContext> options)
            : base(options)
        { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            => modelBuilder.InitialSeed();
    }
}
