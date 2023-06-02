using KidegaApp.DataTransferObjects.Requests;
using KidegaApp.DataTransferObjects.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidegaApp.Services.Services
{
    public interface IProductService
    {
        Task<ProductDisplayResponse> GetProductAsync(int id);
        Task<IEnumerable<ProductDisplayResponse>> GetProductDisplayResponsesAsync();
        Task<IEnumerable<ProductDisplayResponse>> GetProductsByCategoryAsync(int categoryId);
        Task CreateProductAsync(CreateNewProductRequest createNewProductRequest);

        ProductDisplayResponse GetProduct(int id);
        IEnumerable<ProductDisplayResponse> GetProductDisplayResponses();
        IEnumerable<ProductDisplayResponse> GetProductsByCategory(int categoryId);
        void CreateProduct(CreateNewProductRequest createNewProductRequest);
    }
}
