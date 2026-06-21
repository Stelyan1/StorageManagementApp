using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManagement.Infrastructure.DTO_s
{
    public class ProductSeedDTO
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string Supplier { get; set; } = null!;

        public string Manufacturer { get; set; } = null!;

        public string ProductType { get; set; } = null!;

        public string Description { get; set; } = null!;

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
