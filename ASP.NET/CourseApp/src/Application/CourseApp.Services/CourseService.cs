using AutoMapper;
using CourseApp.DataTransferObjects.Requests;
using CourseApp.DataTransferObjects.Responses;
using CourseApp.Entities;
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

        public CourseDisplayResponse GetCourse(int id)
        {
            var course = repository.Get(id);
            return _mapper.Map<CourseDisplayResponse>(course);
        }

        public IEnumerable<CourseDisplayResponse> GetCourseDisplayResponses()
        {
            var courses = repository.GetAll();
            var response = courses.ConvertToDisplayResponses(_mapper);
            return response;
            
        }

		public IEnumerable<CourseDisplayResponse> GetCoursesByCategory(int categoryId)
		{
			var courses = repository.GetCoursesByCategory(categoryId);
            var response = courses.ConvertToDisplayResponses(_mapper);
            return response;
		}

        public async Task CreateCourseAsync(CreateNewCourseRequest createNewCourseRequest)
        {
            var course = _mapper.Map<Course>(createNewCourseRequest);
            await repository.CreateAsync(course);
        }

        public async Task UpdateCourse(UpdateCourseRequest updateCourseRequest)
        {
            var course = _mapper.Map<Course>(updateCourseRequest);
            await repository.UpdateAsync(course);
        }

        public async Task<bool> CourseIsExists(int courseId)
        {
            return await repository.IsExistsAsync(courseId);
        }

        public async Task<UpdateCourseRequest> GetCourseForUpdateAsync(int id)
        {
            var course = await repository.GetAsync(id);
            return _mapper.Map<UpdateCourseRequest>(course);
        }

        public async Task<IEnumerable<CourseDisplayResponse>> SearchByName(string name)
        {
            var courses = await repository.GetCoursesByName(name);
            var response = _mapper.Map<IEnumerable<CourseDisplayResponse>>(courses);
            return response;
        }

        public async Task<int> CreateCourseAndReturnIdAsync(CreateNewCourseRequest createNewCourseRequest)
        {
            var course = _mapper.Map<Course>(createNewCourseRequest);
            await repository.CreateAsync(course);
            return course.Id;
        }

        public async Task DeleteAsync(int id)
        {
            await repository.DeleteAsync(id);
        }
    }
}