using KidegaApp.DataTransferObjects.Responses;
using Microsoft.AspNetCore.Mvc;

namespace KidegaApp.Mvc.ViewComponents
{
    public class ProductList : ViewComponent
    {
        public IViewComponentResult Invoke(IEnumerable<ProductDisplayResponse> model)
        {
            return View(model);
        }
    }
}
