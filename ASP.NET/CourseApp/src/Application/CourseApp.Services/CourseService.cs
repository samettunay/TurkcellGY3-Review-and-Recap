using AutoMapper;
using CourseApp.DataTransferObjects.Responses;
using CourseApp.Infrastructure.Repositories;
using CourseApp.Services.Extensions;

namespace CourseApp.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository repository;
        private readonly IMapper _mapper;
        public CourseService(ICourseRepository repository, IMapper mapper)
        {
            this.repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<CourseDisplayResponse> GetCourseDisplayResponses()
        {
            var courses = repository.GetAll();
            var response = courses.ConvertToDisplayResponses(_mapper);
            return response;
            
        }
    }
}