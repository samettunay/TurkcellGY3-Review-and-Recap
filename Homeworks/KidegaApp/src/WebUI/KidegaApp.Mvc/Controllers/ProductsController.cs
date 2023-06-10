using KidegaApp.DataTransferObjects.Requests;
using KidegaApp.DataTransferObjects.Responses;
using KidegaApp.Mvc.Models;
using KidegaApp.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.IdentityModel.Tokens;
using System.Data;

namespace KidegaApp.Mvc.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService categoryService;

        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            this.categoryService = categoryService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index(ProductFilterModel filterModel)
        {
            IEnumerable<ProductDisplayResponse> products;

            if (filterModel.CampaignId.HasValue)
            {
                products = await _productService.GetProductsByCampaignAsync(filterModel.CampaignId.Value);
                ViewBag.NavigationInfo = "Kampanyalar";
            } 
            else if (filterModel.CategoryId.HasValue)
            {
                products = await _productService.GetProductsByCategoryAsync(filterModel.CategoryId.Value);
                ViewBag.NavigationInfo = "Kategoriler";
            }
            else
            {
                products = await _productService.GetProductDisplayResponsesAsync();
                ViewBag.NavigationInfo = "Tüm Ürünler";
            }

            ViewBag.ProductModelForFilterMenu = products;

            if (!filterModel.BrandName.IsNullOrEmpty())
            {
                products = products.Where(p=>p.BrandName==filterModel.BrandName);
            }

            if (filterModel.MinPrice.HasValue && filterModel.MaxPrice.HasValue)
            {
                products = products.Where(p => p.Price >= filterModel.MinPrice && p.Price <= filterModel.MaxPrice);
            }

            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = getCategoriesForSelectList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateNewProductRequest request)
        {
            if (ModelState.IsValid)
            {
                await _productService.CreateProductAsync(request);
                return RedirectToAction(nameof(Index));
            }


            ViewBag.Categories = getCategoriesForSelectList();
            return View();

        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.Categories = getCategoriesForSelectList();
            var course = await _productService.GetProductForUpdate(id);

            return View(course);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, UpdateProductRequest updateProductRequest)
        {
            if (await _productService.ProductIsExists(id))
            {
                if (ModelState.IsValid)
                {
                    await _productService.UpdateProduct(updateProductRequest);
                    return RedirectToAction(nameof(Index));
                }
                ViewBag.Categories = getCategoriesForSelectList();
                return View();
            }
            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Remove()
        {
            ViewBag.Categories = getCategoriesForSelectList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Remove(int id)
        {
            await _productService.RemoveProduct(id);
            return View();
        }

        private IEnumerable<SelectListItem> getCategoriesForSelectList()
        {
            var categories = categoryService.GetCategoriesForList().Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() }).ToList();
            return categories;
        }


    }
}
