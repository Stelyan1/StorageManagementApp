using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StorageManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StorageManagement.Common.EntityValidationConstants.Product;

namespace StorageManagement.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .HasMaxLength(NameMaxLength);

            builder.Property(p => p.ImageUrl)
                   .IsRequired();

            builder.Property(p => p.Supplier)
                   .HasMaxLength(SupplierMaxLength)
                   .IsRequired();

            builder.Property(p => p.Manufacturer)
                   .HasMaxLength(ManufacturerMaxLength)
                   .IsRequired();

            builder.Property(p => p.ProductType)
                   .HasMaxLength(ProductTypeMaxLength);

            builder.Property(p => p.Description)
                   .HasMaxLength(DescriptionMaxLength)
                   .IsRequired();

            builder.Property(p => p.Quantity)
                   .IsRequired();

            builder.Property(p => p.Price)
                   .HasColumnType("decimal(18, 2)")
                   .IsRequired();

            builder.Property(p => p.CreatedOn)
                   .IsRequired();

            builder.Property(p => p.UpdatedOn)
                   .IsRequired(false);

            builder.HasData(SeedProducts());
        }

        private IEnumerable<Product> SeedProducts()
        {
            IEnumerable<Product> products = new List<Product>()
            {
                new Product()
                {
                 Id = Guid.Parse("0b8d4c0f-0a3f-4c95-9f22-1e4f7c2b9a11"),
                 Name = "ASUS TUF Gaming GeForce RTX 4070 Ti 12GB",
                 ImageUrl = "https://dlcdnwebimgs.asus.com/gain/32d8b7ad-5b28-485b-b440-54813c57e4cb/w692",
                 Supplier = "ASUS",
                 Manufacturer = "ASUS",
                 ProductType = "Video Card",
                 Description = "NVIDIA GeForce RTX 4070 Ti gaming graphics card with 12GB GDDR6X memory.",
                 Quantity = 5,
                 Price = 899.99m,
                 CreatedOn = DateTime.UtcNow,
                 UpdatedOn = null
                },

                new Product()
                {
                 Id = Guid.Parse("2f4f1a7d-8d15-4c7e-b5a1-3b31797b1c21"),
                 Name = "AMD Ryzen 7 7800X3D",
                 ImageUrl = "https://www.amd.com/content/dam/amd/en/images/products/processors/ryzen/2505503-ryzen-7-7800x3d.jpg",
                 Supplier = "AMD",
                 Manufacturer = "AMD",
                 ProductType = "Processor",
                 Description = "AMD Ryzen 7 7800X3D desktop processor with AMD 3D V-Cache technology.",
                 Quantity = 8,
                 Price = 389.99m,
                 CreatedOn = DateTime.UtcNow,
                 UpdatedOn = null
                },

                new Product()
                {
                 Id = Guid.Parse("6c1846e2-55a6-4d63-a7d1-936c7a7a7e31"),
                 Name = "Kingston FURY Beast DDR5 32GB",
                 ImageUrl = "https://desktop.bg/system/images/355088/original/32gb_2x_16gb_ddr5_5600mhz_kingston_fury_beast_rgb.jpg",
                 Supplier = "Kingston",
                 Manufacturer = "Kingston",
                 ProductType = "RAM",
                 Description = "Kingston FURY Beast DDR5 memory kit for gaming and high-performance systems.",
                 Quantity = 12,
                 Price = 129.99m,
                 CreatedOn = DateTime.UtcNow,
                 UpdatedOn = null
                },

                new Product()
                {
                  Id = Guid.Parse("a9df4c1b-29c7-4e52-bf95-7f8d3f76e141"),
                  Name = "ASUS ROG STRIX B650-A GAMING WIFI",
                  ImageUrl = "https://dlcdnwebimgs.asus.com/files/media/3151EBBB-8450-43F6-9994-D7E5E6A9D0E5/v1/img/spec/performance-m.png",
                  Supplier = "ASUS",
                  Manufacturer = "ASUS",
                  ProductType = "Motherboard",
                  Description = "ASUS ROG STRIX B650-A GAMING WIFI AM5 motherboard with DDR5 and PCIe support.",
                  Quantity = 6,
                  Price = 269.99m,
                  CreatedOn = DateTime.UtcNow,
                  UpdatedOn = null
                },

                new Product()
                {
                 Id = Guid.Parse("d42a62ff-12ef-4c6f-9b7e-71a6f9e29c88"),
                 Name = "ASUS TUF Gaming VG27AQ",
                 ImageUrl = "https://media.mts.ee/eyJidWNrZXQiOiJtdHMtcHJvZHVjdC1pbWFnZXMiLCJrZXkiOiIwXC8wNFwvMDQ2ZmQyNWNiZTIwZTBmZTM2NDNlOGJhMTFmNGU0OTMuanBnIiwiZWRpdHMiOnsicmVzaXplIjp7IndpZHRoIjoxMjAwLCJoZWlnaHQiOjYzMCwiZml0IjoiY29udGFpbiIsImJhY2tncm91bmQiOnsiciI6MjU1LCJnIjoyNTUsImIiOjI1NSwiYWxwaGEiOjF9fX19",
                 Supplier = "ASUS",
                 Manufacturer = "ASUS",
                 ProductType = "Monitor",
                 Description = "27-inch WQHD gaming monitor with IPS panel and up to 165Hz refresh rate.",
                 Quantity = 4,
                 Price = 329.99m,
                 CreatedOn = DateTime.UtcNow,
                 UpdatedOn = null
                },

                new Product()
                {
                 Id = Guid.Parse("ef3b4d91-83b7-4b3e-b51f-9d11b8f8c901"),
                 Name = "Noctua NH-D15",
                 ImageUrl = "https://ardes.bg/uploads/original/noctua-ohladitel-cpu-cooler-nh-d15-g2-lbc-565288.jpg",
                 Supplier = "Noctua",
                 Manufacturer = "Noctua",
                 ProductType = "CPU Cooler",
                 Description = "Premium dual-tower CPU cooler with two 140mm fans.",
                 Quantity = 7,
                 Price = 109.99m,
                 CreatedOn = DateTime.UtcNow,
                 UpdatedOn = null
                }
            };

            return products;
        }
    }
}
