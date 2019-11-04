using CoffeeMug.Infrastructure.Commands;
using CoffeeMug.Infrastructure.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMug.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private IProductsService _productService;
        public ProductsController(IProductsService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _productService.List();
            
            return Json(products);
        }


        [HttpGet("{productId}")]
        public async Task<IActionResult> Get(Guid productId)
        {
            var product = await _productService.GetProductById(productId);

            return new JsonResult(product);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProduct command)
        {
            if (!Validator.CreateProductValidation.CreatProductValidate.Validate(command))
            {
                return BadRequest();
            }

            var result = await _productService.AddProduct(command.ProductName, command.ProductPrice);
            return new JsonResult(result);
        }

        [HttpPut("{productId}")]
        public async Task<IActionResult> Put(Guid productId, [FromBody] UpdateProduct command)
        {
            if (!Validator.UpdateProductValidation.UpdateProductValidate.Validate(command))
            {
                return BadRequest();
            }

            await _productService.UpdateProduct(productId, command.ProductName, command.ProductPrice);
            return NoContent();
        }

        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(Guid productId)
        {
            await _productService.RemoveProduct(productId);
            return NoContent();
        }
    }
}
