using KidegaApp.DataTransferObjects.Requests;
using KidegaApp.DataTransferObjects.Responses;
using KidegaApp.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace KidegaApp.Mvc.Controllers
{
    public class ShoppingController : Controller
    {
        private readonly IBasketService _basketService;
        private readonly IProductService _productService;
        public ShoppingController(IBasketService basketService, IProductService productService)
        {
            _basketService = basketService;
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var basketItems = await _basketService.GetBasketItemsForUser();
            
            return View(basketItems);
        }

        public async Task<IActionResult> AddProduct(int id)
        {
            var selectedProduct = _productService.GetProduct(id);

            CreateNewBasketItemRequest request = new CreateNewBasketItemRequest
            {
                ProductId = selectedProduct.Id,
                Quantity = 1,
            };
            await _basketService.AddItemToBasketAsync(request);

            return Json(new { message = $"{selectedProduct.Name} Sepete eklendi" });
        }

        public async Task<IActionResult> RemoveProduct(int id)
        {
            await _basketService.RemoveBasketItemAsync(id);

            return RedirectToAction(nameof(Index));
        }

    }
}
