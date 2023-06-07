using KidegaApp.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace KidegaApp.Mvc.Controllers
{
    public class ShoppingController : Controller
    {
        private readonly IBasketService _basketService;
        private readonly IUserService _userService;

        public ShoppingController(IBasketService basketService, IUserService userService)
        {
            _basketService = basketService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            //HttpContext.User.Identity.Name
            //var user = _userService.GetUserByUserNameAsync(userName);
            // var basket = _basketService.GetBasketByUserIdAsync();
            return View();
        }

    }
}
