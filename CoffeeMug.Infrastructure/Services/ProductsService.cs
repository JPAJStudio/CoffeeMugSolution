using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CoffeeMug.Core.Domain;
using CoffeeMug.Core.Repositories;
using CoffeeMug.Infrastructure.DTO;

namespace CoffeeMug.Infrastructure.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository _productRepository = null;
        private readonly IMapper _mapper = null;


        public ProductsService(IProductsRepository repository, IMapper mapper)
        {
            _productRepository = repository;
            _mapper = mapper;
        }
        public async Task<Guid> AddProduct(string Name, decimal Price)
        {
            Guid id = Guid.NewGuid();
            var product = await _productRepository.GetProductById(id);
            if(product != null)
            {
                throw new Exception($"Event with id: {id} already exists!");
            }

            product = new Product(id, Name, Price);
            await _productRepository.AddProduct(product);
            return id;
        }

        public async Task<ProductDTO> GetProductById(Guid Id)
        {
            var product = await _productRepository.GetProductById(Id);

            return _mapper.Map<ProductDTO>(product);
        }

        public async Task<IEnumerable<ProductDTO>> List()
        {
            var products = await _productRepository.List();

            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }

        public async Task RemoveProduct(Guid Id)
        {
            var product = await _productRepository.GetProductById(Id);
            if(product == null)
            {
                throw new Exception($"Cannot find product with id: {Id}");
            }
            await _productRepository.RemoveProduct(product);
        }

        public async Task UpdateProduct(Guid Id, string Name, decimal Price)
        {
            var product = await _productRepository.GetProductById(Id);
            if (product == null)
            {
                throw new Exception($"Product width id: {Id} not exists!");
            }

            product.SetName(Name);
            product.SetPrice(Price);
            await _productRepository.UpdateProduct(product);
        }
    }
}
