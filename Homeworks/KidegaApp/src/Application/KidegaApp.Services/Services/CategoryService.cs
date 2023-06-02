using AutoMapper;
using KidegaApp.DataTransferObjects.Responses;
using KidegaApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidegaApp.Services.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository repository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository repository, IMapper mapper)
        {
            this.repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<CategoryDisplayResponse> GetCategoriesForList()
        {
            var categories = repository.GetAll();
            var response = _mapper.Map<IEnumerable<CategoryDisplayResponse>>(categories);
            return response;
        }

        public async Task<IEnumerable<CategoryDisplayResponse>> GetCategoriesForListAsync()
        {
            var categories = await repository.GetAllAsync();
            var response = _mapper.Map<IEnumerable<CategoryDisplayResponse>>(categories);
            return response;
        }
    }
}
