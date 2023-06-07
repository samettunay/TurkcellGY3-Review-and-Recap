using KidegaApp.DataTransferObjects.Responses;
using KidegaApp.Mvc.Models;
using KidegaApp.Services.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace KidegaApp.Mvc.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

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

    }
}
