using KidegaApp.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace KidegaApp.Mvc.ViewComponents
{
    public class CategoryListViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await _categoryService.GetCategoriesForListAsync();
            return View(categories);
        }
    }
}
