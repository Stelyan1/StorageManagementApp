using Microsoft.EntityFrameworkCore;
using StorageManagement.Data;
using StorageManagement.Data.Models;
using StorageManagement.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManagement.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly StorageManagementDbContext _dbContext;

        public ProductRepository(StorageManagementDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public IQueryable<Product> All()
        {
            return _dbContext.Products.AsQueryable();
        }

        public async Task<Product?> GetByIdAsync(Guid id)
        {
            return await _dbContext.Products.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task AddAsync(Product product)
        {
            await _dbContext.Products.AddAsync(product);
        }

        public void Update(Product product)
        {
            _dbContext.Products.Update(product);
        }

        public void Delete(Product product)
        {
            _dbContext.Products.Remove(product);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
