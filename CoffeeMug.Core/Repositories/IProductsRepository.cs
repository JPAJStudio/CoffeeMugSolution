using CoffeeMug.Core.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoffeeMug.Core.Repositories
{
    public interface IProductsRepository
    {
        Task<IEnumerable<Product>> List();

        Task<Product> GetProductById(Guid Id);

        Task<Guid> AddProduct(Product Product);

        Task UpdateProduct(Product Product);

        Task RemoveProduct(Product Product);
    }
}