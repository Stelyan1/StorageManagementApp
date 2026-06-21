using Microsoft.EntityFrameworkCore;
using StorageManagement.Data.Models;
using StorageManagement.Infrastructure.Repositories.Interfaces;
using StorageManagement.Infrastructure.Services.Interfaces;
using StorageManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManagement.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public async Task<List<ProductIndexViewModel>> GetAllAsync(string? searchTerm, int? minQuantity)
        {
            var products = _productRepository.All();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                products = products.Where(p => p.Name.Contains(searchTerm));
            }

            if (minQuantity.HasValue)
            {
                products = products.Where(p => p.Quantity >= minQuantity.Value);
            }

            return await products
                .OrderBy(p => p.Name)
                .Select(p => new ProductIndexViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    ImageUrl = p.ImageUrl,
                    Supplier = p.Supplier,
                    Manufacturer = p.Manufacturer,
                    ProductType = p.ProductType,
                    Description = p.Description,
                    Quantity = p.Quantity,
                    Price = p.Price
                })
                .ToListAsync();
        }

        public async Task<ProductFormViewModel?> GetByIdAsync(Guid id)
        {
            var product = await _productRepository.GetByIdAsync(id);

            if (product == null)
            {
                return null;
            }

            return new ProductFormViewModel
            {
                Id = product.Id,
                Name = product.Name,
                ImageUrl = product.ImageUrl,
                Supplier = product.Supplier,
                Manufacturer = product.Manufacturer,
                ProductType = product.ProductType,
                Description = product.Description,
                Quantity = product.Quantity,
                Price = product.Price
            };
        }

        public async Task AddAsync(ProductFormViewModel model)
        {
            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                ImageUrl = model.ImageUrl,
                Supplier = model.Supplier,
                Manufacturer = model.Manufacturer,
                ProductType = model.ProductType,
                Description = model.Description,
                Quantity = model.Quantity,
                Price = model.Price,
                CreatedOn = DateTime.UtcNow
            };

            await _productRepository.AddAsync(product);
            await _productRepository.SaveChangesAsync();
        }

        public async Task<bool> UpdateAsync(Guid id, ProductFormViewModel model)
        {
            var product = await _productRepository.GetByIdAsync(id);

            if (product == null)
            {
                return false;
            }

            product.Name = model.Name;
            product.ImageUrl = model.ImageUrl;
            product.Supplier = model.Supplier;
            product.Manufacturer = model.Manufacturer;
            product.ProductType = model.ProductType;
            product.Description = model.Description;
            product.Quantity = model.Quantity;
            product.Price = model.Price;
            product.UpdatedOn = DateTime.UtcNow;

            _productRepository.Update(product);
            await _productRepository.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var product = await _productRepository.GetByIdAsync(id);

            if (product == null)
            {
                return false;
            }

            _productRepository.Delete(product);
            await _productRepository.SaveChangesAsync();

            return true;
        }

        public async Task<ReportViewModel> GetReportsAsync()
        {
            var products = await _productRepository.All().ToListAsync();

            return new ReportViewModel
            {
                TotalQuantity = products.Sum(p => p.Quantity),
                TotalInventoryValue = products.Sum(p => p.Price * p.Quantity),
                LowStockCount = products.Count(p => p.Quantity <= 5),
                AllArticlesCount = products.Count
            };
        }

    }
}
