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

        public IViewComponentResult Invoke(int id)
        {
            var product = _productService.GetProduct(id);
            var dealOfWeek = new DealOfWeek()
            {
                Name = "Haftanın Fırsatları",
                DiscountRate = 30,
                Product = product
            };
            dealOfWeek.ApplyDiscount();
            return View(dealOfWeek);
        }
    }
}
