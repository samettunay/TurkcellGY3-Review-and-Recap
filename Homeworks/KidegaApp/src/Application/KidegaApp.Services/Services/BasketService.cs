using AutoMapper;
using KidegaApp.DataTransferObjects.Requests;
using KidegaApp.DataTransferObjects.Responses;
using KidegaApp.Entities;
using KidegaApp.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidegaApp.Services.Services
{
    public class BasketService : IBasketService
    {
        private readonly IBasketItemRepository _basketItemRepository;
        private readonly IBasketRepository _basketRepository;
        private readonly IMapper _mapper;

        public BasketService(IBasketItemRepository repository, IMapper mapper, IBasketRepository basketRepository)
        {
            _basketItemRepository = repository;
            _mapper = mapper;
            _basketRepository = basketRepository;
        }

        public async Task AddItemToBasketAsync(CreateNewBasketItemRequest createNewBasketItemRequest)
        {
            var exists = await _basketItemRepository.GetWithPredicateAsync(b => b.BasketId == createNewBasketItemRequest.BasketId && b.ProductId == createNewBasketItemRequest.ProductId);
            if (exists != null)
            {
                exists.Quantity += 1;
                await _basketItemRepository.UpdateAsync(exists);
            }
            else
            {
                var basketItem = _mapper.Map<BasketItem>(createNewBasketItemRequest);
                await _basketItemRepository.CreateAsync(basketItem);
            }
        }

        public async Task<IList<BasketItemDisplayResponse>> GetAllByBasketItemIdAsync(int basketItemId)
        {
            var basketItems = await _basketItemRepository.GetAllByBasketIdAsync(basketItemId);
            var response = _mapper.Map<IList<BasketItemDisplayResponse>>(basketItems);
            return response;
        }

        public async Task<Basket> GetBasketByUserIdAsync(int userId)
        {
            return await _basketRepository.GetWithPredicateAsync(b=>b.UserId == userId);
        }

        public async Task RemoveBasketItemAsync(int basketItemId)
        {
            var exists = await _basketItemRepository.GetWithPredicateAsync(b => b.Id == basketItemId);
            if (exists != null && exists.Quantity > 1)
            {
                exists.Quantity -= 1;
                await _basketItemRepository.UpdateAsync(exists);
            }
            await _basketItemRepository.DeleteAsync(basketItemId);
        }
    }
}
