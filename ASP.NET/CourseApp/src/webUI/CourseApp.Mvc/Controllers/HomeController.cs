using CourseApp.Entities;
using CourseApp.Mvc.Models;
using CourseApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CourseApp.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICourseService _courseService;
        public HomeController(ILogger<HomeController> logger, ICourseService courseService)
        {
            _logger = logger;
            _courseService = courseService;
        }

        public IActionResult Index(int pageNo=1, int? id = null)
        {
            var courses = id == null ? _courseService.GetCourseDisplayResponses() : 
                                    _courseService.GetCoursesByCategory(id.Value);

            var coursePerPage = 4;
            var courseCount = courses.Count();
            var totalPage = Math.Ceiling((decimal)courseCount / coursePerPage);

            var pagingInfo = new PagingInfo
            {
                CurrentPage = pageNo,
                ItemsPerPage = coursePerPage,
                TotalItems = courseCount
            };

            var paginatedCourses = courses.OrderBy(c => c.Id)
                                          .Skip((pageNo-1) * coursePerPage)
                                          .Take(coursePerPage)
                                          .ToList();

            var model = new PaginationCourseViewModel
            {
                Courses = paginatedCourses,
                PagingInfo = pagingInfo
            };


            return View(model);
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