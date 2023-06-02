using KidegaApp.DataTransferObjects.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidegaApp.Services.Services
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDisplayResponse> GetCategoriesForList();
        Task<IEnumerable<CategoryDisplayResponse>> GetCategoriesForListAsync();
    }
}
