using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StorageManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class LittleChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b8d4c0f-0a3f-4c95-9f22-1e4f7c2b9a11"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 21, 20, 49, 35, 178, DateTimeKind.Utc).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f4f1a7d-8d15-4c7e-b5a1-3b31797b1c21"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 21, 20, 49, 35, 178, DateTimeKind.Utc).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c1846e2-55a6-4d63-a7d1-936c7a7a7e31"),
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2026, 6, 21, 20, 49, 35, 178, DateTimeKind.Utc).AddTicks(4706), "https://desktop.bg/system/images/355088/original/32gb_2x_16gb_ddr5_5600mhz_kingston_fury_beast_rgb.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a9df4c1b-29c7-4e52-bf95-7f8d3f76e141"),
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2026, 6, 21, 20, 49, 35, 178, DateTimeKind.Utc).AddTicks(4710), "https://dlcdnwebimgs.asus.com/files/media/3151EBBB-8450-43F6-9994-D7E5E6A9D0E5/v1/img/spec/performance-m.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d42a62ff-12ef-4c6f-9b7e-71a6f9e29c88"),
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2026, 6, 21, 20, 49, 35, 178, DateTimeKind.Utc).AddTicks(4713), "https://media.mts.ee/eyJidWNrZXQiOiJtdHMtcHJvZHVjdC1pbWFnZXMiLCJrZXkiOiIwXC8wNFwvMDQ2ZmQyNWNiZTIwZTBmZTM2NDNlOGJhMTFmNGU0OTMuanBnIiwiZWRpdHMiOnsicmVzaXplIjp7IndpZHRoIjoxMjAwLCJoZWlnaHQiOjYzMCwiZml0IjoiY29udGFpbiIsImJhY2tncm91bmQiOnsiciI6MjU1LCJnIjoyNTUsImIiOjI1NSwiYWxwaGEiOjF9fX19" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef3b4d91-83b7-4b3e-b51f-9d11b8f8c901"),
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2026, 6, 21, 20, 49, 35, 178, DateTimeKind.Utc).AddTicks(4718), "https://ardes.bg/uploads/original/noctua-ohladitel-cpu-cooler-nh-d15-g2-lbc-565288.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b8d4c0f-0a3f-4c95-9f22-1e4f7c2b9a11"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 21, 20, 37, 37, 754, DateTimeKind.Utc).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f4f1a7d-8d15-4c7e-b5a1-3b31797b1c21"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 21, 20, 37, 37, 754, DateTimeKind.Utc).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c1846e2-55a6-4d63-a7d1-936c7a7a7e31"),
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2026, 6, 21, 20, 37, 37, 754, DateTimeKind.Utc).AddTicks(9044), "https://media.kingston.com/kingston/product/ktc-product-memory-beast-ddr5-rgb-kf560c36bbeak2-32-1-lg.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a9df4c1b-29c7-4e52-bf95-7f8d3f76e141"),
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2026, 6, 21, 20, 37, 37, 754, DateTimeKind.Utc).AddTicks(9047), "https://dlcdnwebimgs.asus.com/gain/6f7b1c85-0e0e-49d8-87ec-9c3d5f3f1f8f/w692" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d42a62ff-12ef-4c6f-9b7e-71a6f9e29c88"),
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2026, 6, 21, 20, 37, 37, 754, DateTimeKind.Utc).AddTicks(9056), "https://dlcdnwebimgs.asus.com/gain/5c24c2d0-3e2e-4f3f-9a0a-6e9c7f0c1c3c/w692" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef3b4d91-83b7-4b3e-b51f-9d11b8f8c901"),
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2026, 6, 21, 20, 37, 37, 754, DateTimeKind.Utc).AddTicks(9061), "https://noctua.at/pub/media/catalog/product/n/h/nh_d15_1_1.jpg" });
        }
    }
}
