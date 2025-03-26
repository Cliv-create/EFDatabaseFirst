using EFDatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace EFDatabaseFirst.Repositories
{
    public class ProductRepository
    {
        public List<Product>? GetAllProducts()
        {
            using var context = new StoreDbContext();
            var products = context.Products
                .Include(p => p.IdCategoryNavigation)
                .ToList();
            
            return products;
        }

        public ProductRepository AddProduct(Product product)
        {
            using var context = new StoreDbContext();
            var _product = new Product { 
                Id = product.Id,
                Name = product.Name,
                IdCategory = product.IdCategory,
                Price = product.Price,
                Quantity = product.Quantity,
                IdProducer = product.IdProducer,
                IdMeasurement = product.IdMeasurement,
                IdMarkup = product.IdMarkup
            };

            context.Products?.Add(_product);
            context.SaveChanges();
            Console.WriteLine($"Product {_product.Name} was added!");

            return this;
        }

        public ProductRepository UpdateProduct(int product_id, Product product)
        {
            using var context = new StoreDbContext();

            // Attach the modified product
            product.Id = product_id; // Ensure ID is set correctly
            context.Products.Update(product);

            context.SaveChanges();
            
            return this;
        }

        public ProductRepository DeleteProduct(int product_id)
        {
            using var context = new StoreDbContext();
            var _product = context.Products?
                .FirstOrDefault(p => p.Id == product_id);
            if (_product == null)
            {
                Console.WriteLine($"Product with ID {product_id} was not found!");
                return this;
            }

            context.Products?.Remove(_product);
            context.SaveChanges();
            Console.WriteLine($"Product with ID {product_id} was deleted!");

            return this;
        }

        public List<Product>? GetProductsWithCategory()
        {
            using var context = new StoreDbContext();

            var products = context.Products
                .Include(p => p.IdCategoryNavigation)
                .ToList();
            
            return products;
        }
    }
}