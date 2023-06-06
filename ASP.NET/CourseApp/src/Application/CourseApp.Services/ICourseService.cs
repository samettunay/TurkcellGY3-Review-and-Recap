
using CourseApp.DataTransferObjects.Requests;
using CourseApp.DataTransferObjects.Responses;

namespace CourseApp.Services
{
    public interface ICourseService
    {
        CourseDisplayResponse GetCourse(int id);
        Task<UpdateCourseRequest> GetCourseForUpdateAsync(int id);
        IEnumerable<CourseDisplayResponse> GetCourseDisplayResponses();
        IEnumerable<CourseDisplayResponse> GetCoursesByCategory(int categoryId);
        Task CreateCourseAsync(CreateNewCourseRequest createNewCourseRequest);
        Task<int> CreateCourseAndReturnIdAsync(CreateNewCourseRequest createNewCourseRequest);
        Task UpdateCourse(UpdateCourseRequest updateCourseRequest);
        Task<bool> CourseIsExists(int courseId);
        Task<IEnumerable<CourseDisplayResponse>> SearchByName(string name);
        Task DeleteAsync(int id)
    }
}