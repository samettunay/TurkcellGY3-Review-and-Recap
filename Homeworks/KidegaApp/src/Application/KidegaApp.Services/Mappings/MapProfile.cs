using AutoMapper;
using KidegaApp.DataTransferObjects.Requests;
using KidegaApp.DataTransferObjects.Responses;
using KidegaApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidegaApp.Services.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile() 
        {
            CreateMap<Product, ProductDisplayResponse>();
            CreateMap<Category, CategoryDisplayResponse>();
            CreateMap<Campaign, CampaignDisplayResponse>();
            CreateMap<BasketItem,BasketItemDisplayResponse>();

            CreateMap<CreateNewBasketItemRequest, BasketItem>();
            CreateMap<UpdateBasketItemRequest, BasketItem>();
            CreateMap<CreateNewProductRequest, Product>();
            CreateMap<CreateNewCategoryRequest, Category>();
            CreateMap<CreateNewCampaignRequest, Campaign>();
        }
    }
}
