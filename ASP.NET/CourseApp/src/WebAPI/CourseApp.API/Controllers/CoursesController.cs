using CourseApp.API.Filters;
using CourseApp.DataTransferObjects.Requests;
using CourseApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetCourses()
        {
            var courses = _courseService.GetCourseDisplayResponses();
            return Ok(courses);
        }

        [HttpGet("{id}")]
        public IActionResult GetCourse(int id)
        {
            var course = _courseService.GetCourse(id);
            if (course == null)
            {
                return NotFound();
            }
            return Ok(course);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> SearchCourseByName(string name)
        {
            var courses = await _courseService.SearchByName(name);
            return Ok(courses);
        }

        [HttpGet("[action]")]
        public IActionResult SearchCourseByCategory(int id)
        {
            var courses =  _courseService.GetCoursesByCategory(id);
            return Ok(courses);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateNewCourseRequest request)
        {
            if (ModelState.IsValid)
            {
                var lastCourseId = await _courseService.CreateCourseAndReturnIdAsync(request);
                return CreatedAtAction(nameof(GetCourse), routeValues: new {id = lastCourseId}, null);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        [IsExists]
        public async Task<IActionResult> Update(int id, UpdateCourseRequest request)
        {
            if (ModelState.IsValid)
            {
                await _courseService.UpdateCourse(request);
                return Ok();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        [IsExists]
        public async Task<IActionResult> Delete(int id)
        {
            await _courseService.DeleteAsync(id);
            return Ok();
        }

        [HttpGet("[action]")]
        [NotImplemented]
        public async Task<IActionResult> Bitmemis(int id)
        {
            throw new NotImplementedException();
        }
    }
}
