using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManagement.ViewModels
{
    public class ReportViewModel
    {
        public int TotalQuantity { get; set; }

        public decimal TotalInventoryValue { get; set; }

        public int LowStockCount { get; set; }

        public int AllArticlesCount { get; set; }
    }
}
