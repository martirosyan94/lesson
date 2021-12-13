using Microsoft.AspNetCore.Mvc;
using Shop.Business;
using Shop.Business.Models;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("Add")]
        public void AddProduct(ProductViewModel productViewModel)
        {
            _productService.CreateProduct(productViewModel);
        }

        [HttpGet("GetAll")]
        public Task<List<Product>> GetAll()
        {
            return _productService.GetAllProducts();
        }

        [HttpGet("GetByName")]
        public Task<Product> GetProductByName(string name)
        {
            return _productService.GetProductByName(name);
        }

        [HttpDelete("DelById")]
        public void DeleteProduct(Guid id)
        {
            _productService.DeleteProductById(id);
        }

        [HttpPut("Product/Put")]
        public void PutProduct(Guid id, ProductViewModel productViewModel)
        {
            _productService.UpdateProduct(id, productViewModel);
        }
    }
}
