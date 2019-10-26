using CoffeeMug.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMug.Infrastructure.Services
{
    public interface IProductsService
    {
        Task<IEnumerable<ProductDTO>> List();

        Task<ProductDTO> GetProductById(Guid Id);

        Task<Guid> AddProduct(string Name, decimal Price);

        Task UpdateProduct(Guid Id, string Name, decimal Price);

        Task RemoveProduct(Guid Id);
    }
}
