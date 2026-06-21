using System.ComponentModel.DataAnnotations;
using static StorageManagement.Common.EntityValidationConstants.Product;

namespace StorageManagement.ViewModels
{
    public class ProductFormViewModel
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [StringLength(SupplierMaxLength)]
        public string Supplier {  get; set; } = null!;

        [Required]
        [StringLength(ManufacturerMaxLength)]
        public string Manufacturer { get; set; } = null!;

        [Required]
        [StringLength(ProductTypeMaxLength)]
        public string ProductType { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }
    }
}
