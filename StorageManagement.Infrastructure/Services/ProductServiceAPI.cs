using Microsoft.EntityFrameworkCore;
using StorageManagement.Data.Models;
using StorageManagement.Infrastructure.Repositories.Interfaces;
using StorageManagement.Infrastructure.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManagement.Infrastructure.Services
{
    public class ProductServiceAPI : IProductServiceAPI
    {
        private readonly IProductRepository _repository;

        public ProductServiceAPI(IProductRepository repository)
        {
            this._repository = repository;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            var products = await _repository.All().ToListAsync();

            return products;
        }
    }
}
