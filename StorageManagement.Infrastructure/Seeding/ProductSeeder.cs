using Microsoft.EntityFrameworkCore;
using StorageManagement.Data;
using StorageManagement.Data.Models;
using StorageManagement.Infrastructure.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StorageManagement.Infrastructure.Seeding
{
    public class ProductSeeder
    {
        private readonly StorageManagementDbContext _dbContext;

        public ProductSeeder(StorageManagementDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task SeedAsync(string seedRootPath)
        {
            var FilePath = Path.Combine(seedRootPath, "products.json");

            Console.WriteLine($"SEED PATH: {FilePath}");
            Console.WriteLine($"FILE EXISTS: {File.Exists(FilePath)}");

            if (!File.Exists(FilePath))
            {
                return;
            }

            var json = await File.ReadAllTextAsync(FilePath);

            var products = JsonSerializer.Deserialize<List<ProductSeedDTO>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            Console.WriteLine($"PRODUCTS COUNT FROM JSON: {products?.Count}");

            if (products == null || products.Count == 0) 
            {
                return;
            }

            foreach (var dto in products)
            {
                var existingProduct = await _dbContext.Products
                    .FirstOrDefaultAsync(p => p.Id == dto.Id);

                if (existingProduct == null)
                {
                    var product = new Product
                    {
                        Id = dto.Id,
                        Name = dto.Name,
                        ImageUrl = dto.ImageUrl,
                        Supplier = dto.Supplier,
                        Manufacturer = dto.Manufacturer,
                        ProductType = dto.ProductType,
                        Description = dto.Description,
                        Quantity = dto.Quantity,
                        Price = dto.Price,
                        CreatedOn = DateTime.UtcNow
                    };

                    await _dbContext.Products.AddAsync(product);
                }
                else
                {
                    existingProduct.Name = dto.Name;
                    existingProduct.ImageUrl = dto.ImageUrl;
                    existingProduct.Supplier = dto.Supplier;
                    existingProduct.Manufacturer = dto.Manufacturer;
                    existingProduct.ProductType = dto.ProductType;
                    existingProduct.Description = dto.Description;
                    existingProduct.Quantity = dto.Quantity;
                    existingProduct.Price = dto.Price;
                    existingProduct.UpdatedOn = DateTime.UtcNow;
                }
            }

            await _dbContext.SaveChangesAsync();
        }
    }
}
