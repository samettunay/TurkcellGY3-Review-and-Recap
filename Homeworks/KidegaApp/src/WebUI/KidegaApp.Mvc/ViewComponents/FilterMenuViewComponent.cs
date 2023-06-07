using KidegaApp.DataTransferObjects.Responses;
using KidegaApp.Entities;
using KidegaApp.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace KidegaApp.Mvc.ViewComponents
{
    public class FilterMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IEnumerable<ProductDisplayResponse> model)
        {
            ViewBag.Brands = model.Select(p => p.BrandName)
                                     .Distinct()
                                     .ToList();

            ViewBag.MinPriceProduct = model.OrderBy(p => p.Price)
                                              .FirstOrDefault();

            ViewBag.MaxPriceProduct = model.OrderByDescending(p => p.Price)
                                              .FirstOrDefault();

            return View(model);
        }
    }
}
