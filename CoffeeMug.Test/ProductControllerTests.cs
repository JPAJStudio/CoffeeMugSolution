using CoffeeMug.Api.Controllers;
using CoffeeMug.Core.Domain;
using CoffeeMug.Infrastructure.Commands;
using CoffeeMug.Infrastructure.Repositories;
using CoffeeMug.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace CoffeeMug.Test
{
    public class ProductControllerTests
    {
        Mock<IProductsService> _productServiceMock;
        ProductsController _productsController;

        public ProductControllerTests()
        {
            _productServiceMock = new Mock<IProductsService>();
            _productsController = new ProductsController(_productServiceMock.Object);
        }
        

        [Fact]
        public async Task Add_new_product_test()
        {
            CreateProduct newCreateCommand = new CreateProduct
            {
                ProductName = "NewTestProduct",
                ProductPrice = 1500
            };

            var response = await _productsController.Post(newCreateCommand);

            Assert.IsType<JsonResult>(response);
            Assert.IsType<Guid>(((JsonResult)response).Value);
        }

        [Fact]
        public async Task Add_new_product_with_price_equal_to_zero()
        {
            CreateProduct newProductCommand = new CreateProduct
            {
                ProductName = "New Test Product",
                ProductPrice = 0
            };

            var response = await _productsController.Post(newProductCommand);

            Assert.IsType<BadRequestResult>(response);
        }

        [Fact]
        public async Task Add_new_product_with_name_longer_than_100()
        {
            CreateProduct newProductCommand = new CreateProduct
            {
                ProductName = "asdasdasdaasdasdasdaasdasdasdaasdasdasdaasdasdasdaasdasdasdaasdasdasdaasdasdasdaasdasdasdaasdasdasda1",
                ProductPrice = 100
            };

            var response = await _productsController.Post(newProductCommand);

            Assert.IsType<BadRequestResult>(response);
        }

        [Fact]
        public async Task Update_product_test()
        {
            UpdateProduct updateProductCommand = new UpdateProduct
            {
                ProductId = Guid.NewGuid(),
                ProductName = "Updated Product Name",
                ProductPrice = 999
            };

            var response = await _productsController.Put(updateProductCommand.ProductId, updateProductCommand);

            Assert.IsType<NoContentResult>(response);
        }

        [Fact]
        public async Task Update_product_with_id_equal_to_null()
        {
            UpdateProduct command = new UpdateProduct
            {
                ProductId = Guid.Empty,
                ProductName = "Updated Product Name",
                ProductPrice = 999
            };

            var response = await _productsController.Put(command.ProductId, command);

            Assert.IsType<BadRequestResult>(response);
        }

        [Fact]
        public async Task Update_product_with_name_equal_to_null()
        {
            UpdateProduct command = new UpdateProduct
            {
                ProductId = Guid.NewGuid(),
                ProductName = null,
                ProductPrice = 999
            };

            var response = await _productsController.Put(command.ProductId, command);

            Assert.IsType<BadRequestResult>(response);
        }

        [Fact]
        public async Task Update_product_with_price_equal_to_zero()
        {
            UpdateProduct command = new UpdateProduct
            {
                ProductId = Guid.NewGuid(),
                ProductName = "Updated Product Name",
                ProductPrice = 0
            };

            var response = await _productsController.Put(command.ProductId, command);
            
            Assert.IsType<BadRequestResult>(response);
        }
    }
}
