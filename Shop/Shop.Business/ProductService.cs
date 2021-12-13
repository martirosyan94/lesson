using Microsoft.EntityFrameworkCore;
using Shop.Business.Models;
using Shop.Data;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business
{
    public class ProductService : IProductService
    {
        private readonly ShopDbContext _context;

        public ProductService(ShopDbContext context)
        {
            _context = context;
        }

        // Create new Product
        public void CreateProduct(ProductViewModel productView)
        {
            var product = new Product()
            {
                Price = productView.Price,
                Name = productView.Name,
                Quantity = productView.Quantity
            };

            _context.Products.Add(product);
            _context.SaveChanges();

        }

        // Get product by name
        public async Task<Product> GetProductByName(string name)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Name == name);
            return product;
        }

        // Get all products
        public Task<List<Product>> GetAllProducts()
        {
            return _context.Products.ToListAsync();
        }

        // Delete product by ID
        public void DeleteProductById(Guid id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        // Update product
        public void UpdateProduct(Guid id, ProductViewModel productView)
        {
            var existingProduct = _context.Products.FirstOrDefault(p => p.Id == id);

            existingProduct.Name = productView.Name;
            existingProduct.Price = productView.Price;
            existingProduct.Quantity = productView.Quantity;

            _context.Products.Update(existingProduct);
            _context.SaveChanges();
        }
    }
}
