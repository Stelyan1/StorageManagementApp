using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StorageManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Identificator of Product"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Name of the Product"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Online image url for the product"),
                    Supplier = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Company that supplies with the product"),
                    Manufacturer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Manufacturer of the product"),
                    ProductType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Product type could be RAM,GPU,CPU or Monitor"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "About the product"),
                    Quantity = table.Column<int>(type: "int", nullable: false, comment: "Available amount in the storage"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Sale price of the product"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date the product have arrived in the storage"),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Used to change arrival date if it's wrong")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedOn", "Description", "ImageUrl", "Manufacturer", "Name", "Price", "ProductType", "Quantity", "Supplier", "UpdatedOn" },
                values: new object[,]
                {
                    { new Guid("0b8d4c0f-0a3f-4c95-9f22-1e4f7c2b9a11"), new DateTime(2026, 6, 21, 20, 37, 37, 754, DateTimeKind.Utc).AddTicks(9033), "NVIDIA GeForce RTX 4070 Ti gaming graphics card with 12GB GDDR6X memory.", "https://dlcdnwebimgs.asus.com/gain/32d8b7ad-5b28-485b-b440-54813c57e4cb/w692", "ASUS", "ASUS TUF Gaming GeForce RTX 4070 Ti 12GB", 899.99m, "Video Card", 5, "ASUS", null },
                    { new Guid("2f4f1a7d-8d15-4c7e-b5a1-3b31797b1c21"), new DateTime(2026, 6, 21, 20, 37, 37, 754, DateTimeKind.Utc).AddTicks(9040), "AMD Ryzen 7 7800X3D desktop processor with AMD 3D V-Cache technology.", "https://www.amd.com/content/dam/amd/en/images/products/processors/ryzen/2505503-ryzen-7-7800x3d.jpg", "AMD", "AMD Ryzen 7 7800X3D", 389.99m, "Processor", 8, "AMD", null },
                    { new Guid("6c1846e2-55a6-4d63-a7d1-936c7a7a7e31"), new DateTime(2026, 6, 21, 20, 37, 37, 754, DateTimeKind.Utc).AddTicks(9044), "Kingston FURY Beast DDR5 memory kit for gaming and high-performance systems.", "https://media.kingston.com/kingston/product/ktc-product-memory-beast-ddr5-rgb-kf560c36bbeak2-32-1-lg.jpg", "Kingston", "Kingston FURY Beast DDR5 32GB", 129.99m, "RAM", 12, "Kingston", null },
                    { new Guid("a9df4c1b-29c7-4e52-bf95-7f8d3f76e141"), new DateTime(2026, 6, 21, 20, 37, 37, 754, DateTimeKind.Utc).AddTicks(9047), "ASUS ROG STRIX B650-A GAMING WIFI AM5 motherboard with DDR5 and PCIe support.", "https://dlcdnwebimgs.asus.com/gain/6f7b1c85-0e0e-49d8-87ec-9c3d5f3f1f8f/w692", "ASUS", "ASUS ROG STRIX B650-A GAMING WIFI", 269.99m, "Motherboard", 6, "ASUS", null },
                    { new Guid("d42a62ff-12ef-4c6f-9b7e-71a6f9e29c88"), new DateTime(2026, 6, 21, 20, 37, 37, 754, DateTimeKind.Utc).AddTicks(9056), "27-inch WQHD gaming monitor with IPS panel and up to 165Hz refresh rate.", "https://dlcdnwebimgs.asus.com/gain/5c24c2d0-3e2e-4f3f-9a0a-6e9c7f0c1c3c/w692", "ASUS", "ASUS TUF Gaming VG27AQ", 329.99m, "Monitor", 4, "ASUS", null },
                    { new Guid("ef3b4d91-83b7-4b3e-b51f-9d11b8f8c901"), new DateTime(2026, 6, 21, 20, 37, 37, 754, DateTimeKind.Utc).AddTicks(9061), "Premium dual-tower CPU cooler with two 140mm fans.", "https://noctua.at/pub/media/catalog/product/n/h/nh_d15_1_1.jpg", "Noctua", "Noctua NH-D15", 109.99m, "CPU Cooler", 7, "Noctua", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
