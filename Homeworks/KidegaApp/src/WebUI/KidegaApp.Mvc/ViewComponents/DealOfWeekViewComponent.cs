using KidegaApp.Mvc.Models;
using KidegaApp.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace KidegaApp.Mvc.ViewComponents
{
    public class DealOfWeekViewComponent : ViewComponent
    {
        private readonly IProductService _productService;

        public DealOfWeekViewComponent(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var product = await _productService.GetProductAsync(id);
            var dealOfWeek = new DealOfWeek()
            {
                Name = "Haftanın Fırsatı",
                DiscountRate = 30,
                Product = product
            };
            dealOfWeek.ApplyDiscount();
            return View(dealOfWeek);
        }
    }
}
