using Shop.Business.Models;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Business
{
    public interface IProductService
    {
        void CreateProduct(ProductViewModel productView);
        void DeleteProductById(Guid id);
        Task<List<Product>> GetAllProducts();
        Task<Product> GetProductByName(string name);
        void UpdateProduct(Guid id, ProductViewModel productView);
    }
}