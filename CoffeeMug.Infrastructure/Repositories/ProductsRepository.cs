using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeMug.Core.Domain;
using CoffeeMug.Core.Repositories;
using CoffeeMug.Infrastructure.DAL;

namespace CoffeeMug.Infrastructure.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private MyDatabaseContext _context = null;
        public ProductsRepository(MyDatabaseContext context)
        {
            _context = context;
        }

        public async Task<Product> GetProductById(Guid Id)
            => await Task.FromResult(_context.Products.SingleOrDefault(product => product.Id == Id));

        public async Task<IEnumerable<Product>> List()
            => await Task.FromResult(_context.Products.AsEnumerable());

        public async Task<Guid> AddProduct(Product Product)
        {
            _context.Products.Add(Product);
            _context.SaveChanges();
            return await Task.FromResult(Product.Id);
        }
        
        public async Task RemoveProduct(Product Product)
        {
            _context.Products.Remove(Product);
            _context.SaveChanges();

            await Task.CompletedTask;
        }

        public Task UpdateProduct(Product Product)
        {
            var product = _context.Products.SingleOrDefault(x => x.Id == Product.Id);
            if(product == null)
            {
                throw new Exception($"Cannot find product with id: {Product.Id}");
            }

            _context.Update(product);
            _context.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
