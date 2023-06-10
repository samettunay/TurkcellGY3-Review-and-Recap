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
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IMapper _mapper;

        public BasketService(IBasketItemRepository repository, IMapper mapper, IBasketRepository basketRepository, IHttpContextAccessor contextAccessor)
        {
            _basketItemRepository = repository;
            _mapper = mapper;
            _basketRepository = basketRepository;
            _contextAccessor = contextAccessor;
        }

        


        public async Task AddItemToBasketAsync(CreateNewBasketItemRequest createNewBasketItemRequest)
        {
            var basket = getUserBasket();
            
            var exists = await _basketItemRepository.GetWithPredicateAsync(b => b.BasketId == basket.Result.Id && b.ProductId == createNewBasketItemRequest.ProductId);
            
            if (exists != null)
            {
                exists.Quantity += 1;
                await _basketItemRepository.UpdateAsync(exists);
            }
            else
            {
                createNewBasketItemRequest.BasketId = basket.Result.Id;
                var basketItem = _mapper.Map<BasketItem>(createNewBasketItemRequest);
                await _basketItemRepository.CreateAsync(basketItem);
            }
        }

        public async Task<IList<BasketItemDisplayResponse>> GetBasketItemsForUser()
        {
            var userName = getUserName();
            var basketItems = await _basketItemRepository.GetBasketItemsByUserNameAsync(userName);
            var response = _mapper.Map<IList<BasketItemDisplayResponse>>(basketItems);
            return response;
        }

        public async Task RemoveBasketItemAsync(int productId)
        {
            var basket = getUserBasket();

            var exists = await _basketItemRepository.GetWithPredicateAsync(b => b.BasketId == basket.Result.Id && b.ProductId == productId);

            if (exists != null)
            {
                if (exists.Quantity > 1)
                {
                    exists.Quantity -= 1;
                    await _basketItemRepository.UpdateAsync(exists);
                }
                else
                {
                    await _basketItemRepository.DeleteAsync(exists.Id);
                }
            }
        }

        private string? getUserName()
        {
            return _contextAccessor.HttpContext?.User?.Identity?.Name;
        }

        private async Task<Basket> getUserBasket()
        {
            string? userName = getUserName();
            var basket = await _basketRepository.GetBasketByUserNameAsync(userName);
            if (basket == null)
            {
                basket = new()
                {
                    UserName = userName,
                };
                await _basketRepository.CreateAsync(basket);
            }
            return basket;
        }
    }
}
