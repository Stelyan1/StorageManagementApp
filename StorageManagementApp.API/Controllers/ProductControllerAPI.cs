using Microsoft.AspNetCore.Mvc;
using StorageManagement.Infrastructure.Services.Interfaces;

namespace StorageManagementApp.API.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductControllerAPI : ControllerBase
    {
        private readonly IProductServiceAPI productService;

        public ProductControllerAPI(IProductServiceAPI productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await productService.GetAllProducts();
            return Ok(products);
        }
    }
}
