using Microsoft.EntityFrameworkCore;
using StorageManagement.Data;
using StorageManagement.Infrastructure.Repositories;
using StorageManagement.Infrastructure.Repositories.Interfaces;
using StorageManagement.Infrastructure.Seeding;
using StorageManagement.Infrastructure.Services;
using StorageManagement.Infrastructure.Services.Interfaces;
using System.Threading.Tasks;

namespace StorageManagementApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<StorageManagementDbContext>(options =>
             options.UseSqlServer(builder.Configuration.GetConnectionString("SQLServer")));

            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<IProductServiceAPI, ProductServiceAPI>();

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<StorageManagementDbContext>();

                dbContext.Database.Migrate();

                var seeder = new ProductSeeder(dbContext);

                var seedPath = Path.Combine(Directory.GetCurrentDirectory(), "..", "StorageManagement.Infrastructure", "Seeding", "SeedData");

                await seeder.SeedAsync(seedPath);
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Products}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
