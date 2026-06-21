using Microsoft.AspNetCore.Mvc;
using StorageManagement.Infrastructure.Services.Interfaces;
using StorageManagement.ViewModels;

namespace StorageManagementApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            this._productService = productService;
        }

        public async Task<IActionResult> Index(string? searchTerm, int? minQuantity)
        {
            var products = await _productService.GetAllAsync(searchTerm, minQuantity);

            ViewBag.SearchTerm = searchTerm;
            ViewBag.MinQuantity = minQuantity;

            return View(products);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var product = await _productService.GetByIdAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await _productService.AddAsync(model);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var product = await _productService.GetByIdAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, ProductFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var updated = await _productService.UpdateAsync(id, model);

            if (!updated)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var product = await _productService.GetByIdAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var deleted = await _productService.DeleteAsync(id);

            if (!deleted)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Reports()
        {
            var report = await _productService.GetReportsAsync();

            return View(report);
        }
    }
}
