using CourseApp.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CourseApp.API.Filters
{
    public class IsExistsFilter : IAsyncActionFilter
    {
        private readonly ICourseService _courseService;

        public IsExistsFilter(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var idParameterIsExists = context.ActionArguments.ContainsKey("id");

            if (!idParameterIsExists)
            {
                context.Result = new BadRequestObjectResult(new { message = $"{context.ActionDescriptor.DisplayName} actionu, id parametresi içermelidir."});
            }
            else
            {
                var id = (int)context.ActionArguments["id"];
                if (await _courseService.CourseIsExists(id))
                {
                    await next.Invoke();
                }
                context.Result = new NotFoundObjectResult(new { message = $"{id} id'li kurs bulunamadı" });
            }
        }
    }
}
