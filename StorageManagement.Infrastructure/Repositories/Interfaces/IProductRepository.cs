using StorageManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManagement.Infrastructure.Repositories.Interfaces
{
    public interface IProductRepository
    {
        IQueryable<Product> All();

        Task<Product?> GetByIdAsync(Guid id);

        Task AddAsync(Product product);

        void Update(Product product);

        void Delete(Product product);

        Task SaveChangesAsync();
    }
}
