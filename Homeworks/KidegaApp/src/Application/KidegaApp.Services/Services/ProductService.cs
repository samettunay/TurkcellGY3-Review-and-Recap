using AutoMapper;
using KidegaApp.DataTransferObjects.Requests;
using KidegaApp.DataTransferObjects.Responses;
using KidegaApp.Entities;
using KidegaApp.Infrastructure.Repositories;
using KidegaApp.Services.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidegaApp.Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository repository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository repository, IMapper mapper)
        {
            this.repository = repository;
            _mapper = mapper;
        }

        public void CreateProduct(CreateNewProductRequest createNewProductRequest)
        {
            var product = _mapper.Map<Product>(createNewProductRequest);
            repository.Create(product);
        }

        public async Task CreateProductAsync(CreateNewProductRequest createNewProductRequest)
        {
            var product = _mapper.Map<Product>(createNewProductRequest);
            await repository.CreateAsync(product);
        }

        public ProductDisplayResponse GetProduct(int id)
        {
            var product = repository.GetById(id);
            return _mapper.Map<ProductDisplayResponse>(product);
        }

        public async Task<ProductDisplayResponse> GetProductAsync(int id)
        {
            var product = await repository.GetByIdAsync(id);
            return _mapper.Map<ProductDisplayResponse>(product);
        }

        public IEnumerable<ProductDisplayResponse> GetProductDisplayResponses()
        {
            var products = repository.GetAll();
            var response = _mapper.Map<IEnumerable<ProductDisplayResponse>>(products);
            return response;
        }

        public async Task<IEnumerable<ProductDisplayResponse>> GetProductDisplayResponsesAsync()
        {
            var products = await repository.GetAllAsync();
            var response = _mapper.Map<IEnumerable<ProductDisplayResponse>>(products);
            return response;
        }

        public IEnumerable<ProductDisplayResponse> GetProductsByBrandName(string brandName)
        {
            var products = repository.GetProductsByBrandName(brandName);
            var response = _mapper.Map<IEnumerable<ProductDisplayResponse>>(products);
            return response;
        }

        public async Task<IEnumerable<ProductDisplayResponse>> GetProductsByBrandNameAsync(string brandName)
        {
            var products = await repository.GetProductsByBrandNameAsync(brandName);
            var response = _mapper.Map<IEnumerable<ProductDisplayResponse>>(products);
            return response;
        }

        public IEnumerable<ProductDisplayResponse> GetProductsByCampaign(int campoaignId)
        {
            var products = repository.GetProductsByCampaign(campoaignId);
            var response = _mapper.Map<IEnumerable<ProductDisplayResponse>>(products);
            return response;
        }

        public async Task<IEnumerable<ProductDisplayResponse>> GetProductsByCampaignAsync(int campaignId)
        {
            var products = await repository.GetProductsByCampaignAsync(campaignId);
            var response = _mapper.Map<IEnumerable<ProductDisplayResponse>>(products);
            return response;
        }

        public IEnumerable<ProductDisplayResponse> GetProductsByCategory(int categoryId)
        {
            var products = repository.GetProductsByCategory(categoryId);
            var response = _mapper.Map<IEnumerable<ProductDisplayResponse>>(products);
            return response;
        }

        public async Task<IEnumerable<ProductDisplayResponse>> GetProductsByCategoryAsync(int categoryId)
        {
            var products = await repository.GetProductsByCategoryAsync(categoryId);
            var response = _mapper.Map<IEnumerable<ProductDisplayResponse>>(products);
            return response;
        }

        public IEnumerable<ProductDisplayResponse> GetProductsByName(string name)
        {
            var products = repository.GetProductsByName(name);
            var response = _mapper.Map<IEnumerable<ProductDisplayResponse>>(products);
            return response;
        }

        public async Task<IEnumerable<ProductDisplayResponse>> GetProductsByNameAsync(string name)
        {
            var products = await repository.GetProductsByNameAsync(name);
            var response = _mapper.Map<IEnumerable<ProductDisplayResponse>>(products);
            return response;
        }

        public async Task<bool> ProductIsExists(int productId)
        {
            return await repository.IsExistsAsync(productId);
        }
        public async Task UpdateProduct(UpdateProductRequest updateProductRequest)
        {
            var product = _mapper.Map<Product>(updateProductRequest);
            await repository.UpdateAsync(product);

        }
        public async Task<UpdateProductRequest> GetProductForUpdate(int id)
        {
            var course = await repository.GetByIdAsync(id);
            return _mapper.Map<UpdateProductRequest>(course);

        }

        public async Task RemoveProduct(int id)
        {
            await repository.DeleteAsync(id);
        }
    }
}
