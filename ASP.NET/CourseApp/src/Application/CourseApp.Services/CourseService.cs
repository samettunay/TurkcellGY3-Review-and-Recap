﻿using AutoMapper;
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
	}
}