using StorageManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManagement.Infrastructure.Services.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductIndexViewModel>> GetAllAsync(string? searchTerm, int? minQuantity);

        Task<ProductFormViewModel?> GetByIdAsync(Guid id);

        Task AddAsync(ProductFormViewModel model);

        Task<bool> UpdateAsync(Guid id, ProductFormViewModel model);

        Task<bool> DeleteAsync(Guid id);

        Task<ReportViewModel> GetReportsAsync();
    }
}
