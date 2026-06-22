using StorageManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManagement.Infrastructure.Services.Interfaces
{
    public interface IProductServiceAPI
    {
        Task<IEnumerable<Product>> GetAllProducts();
    }
}
