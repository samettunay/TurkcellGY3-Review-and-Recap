using KidegaApp.DataTransferObjects.Requests;
using KidegaApp.DataTransferObjects.Responses;
using KidegaApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidegaApp.Services.Services
{
    public interface IProductService
    {
        // Senkron
        ProductDisplayResponse GetProduct(int id);
        void CreateProduct(CreateNewProductRequest createNewProductRequest);
        IEnumerable<ProductDisplayResponse> GetProductDisplayResponses();
        IEnumerable<ProductDisplayResponse> GetProductsByCategory(int categoryId);
        IEnumerable<ProductDisplayResponse> GetProductsByCampaign(int campoaignId);
        IEnumerable<ProductDisplayResponse> GetProductsByBrandName(string brandName);
        IEnumerable<ProductDisplayResponse> GetProductsByName(string name);

        // Asenkron
        Task<ProductDisplayResponse> GetProductAsync(int id);
        Task CreateProductAsync(CreateNewProductRequest createNewProductRequest);
        Task<IEnumerable<ProductDisplayResponse>> GetProductDisplayResponsesAsync();
        Task<IEnumerable<ProductDisplayResponse>> GetProductsByCategoryAsync(int categoryId);
        Task<IEnumerable<ProductDisplayResponse>> GetProductsByCampaignAsync(int campaignId);
        Task<IEnumerable<ProductDisplayResponse>> GetProductsByBrandNameAsync(string brandName);
        Task<IEnumerable<ProductDisplayResponse>> GetProductsByNameAsync(string name);
        Task<UpdateProductRequest> GetProductForUpdate(int id);
        Task<bool> ProductIsExists(int productId);
        Task UpdateProduct(UpdateProductRequest updateProductRequest);
        Task RemoveProduct(int id);
    }
}
