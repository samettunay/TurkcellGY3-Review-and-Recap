
using CourseApp.DataTransferObjects.Requests;
using CourseApp.DataTransferObjects.Responses;

namespace CourseApp.Services
{
    public interface ICourseService
    {
        CourseDisplayResponse GetCourse(int id);
        IEnumerable<CourseDisplayResponse> GetCourseDisplayResponses();
        IEnumerable<CourseDisplayResponse> GetCoursesByCategory(int categoryId);
        Task CreateCourseAsync(CreateNewCourseRequest createNewCourseRequest);
    }
}