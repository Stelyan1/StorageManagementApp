
using StorageManagement.Infrastructure.Repositories;
using StorageManagement.Infrastructure.Repositories.Interfaces;
using StorageManagement.Infrastructure.Services;
using StorageManagement.Infrastructure.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using StorageManagement.Data;

namespace StorageManagementApp.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IProductServiceAPI, ProductServiceAPI>();
            builder.Services.AddScoped<IProductRepository, ProductRepository>();

            builder.Services.AddDbContext<StorageManagementDbContext>(options =>
              options.UseSqlServer(builder.Configuration.GetConnectionString("SQLServer")));

            var app = builder.Build();


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
