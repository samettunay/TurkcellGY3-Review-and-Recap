﻿using KidegaApp.Mvc.Models;
using KidegaApp.Services.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KidegaApp.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService productService;
        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            this.productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.UserName = HttpContext?.User?.Identity?.Name;
            var products = await productService.GetProductDisplayResponsesAsync();
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}