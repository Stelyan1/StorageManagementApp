using Microsoft.EntityFrameworkCore;

namespace StorageManagement.Data.Models
{
    public class Product
    {
        [Comment("Identificator of Product")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Comment("Name of the Product")]
        public string Name { get; set; } = null!;

        [Comment("Online image url for the product")]
        public string ImageUrl { get; set; } = null!;

        [Comment("Company that supplies with the product")]
        public string Supplier { get; set; } = null!;

        [Comment("Manufacturer of the product")]
        public string Manufacturer { get; set; } = null!;

        [Comment("Product type could be RAM,GPU,CPU or Monitor")]
        public string ProductType { get; set; } = null!;

        [Comment("About the product")]
        public string Description { get; set; } = null!;

        [Comment("Available amount in the storage")]
        public int Quantity { get; set; }

        [Comment("Sale price of the product")]
        public decimal Price { get; set; }

        [Comment("Date the product have arrived in the storage")]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        [Comment("Used to change arrival date if it's wrong")]
        public DateTime? UpdatedOn { get; set; }
    }
}
