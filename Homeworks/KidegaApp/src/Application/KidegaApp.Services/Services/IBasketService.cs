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
    public interface IBasketService
    {
        Task<IList<BasketItemDisplayResponse>> GetAllByBasketItemIdAsync(int basketItemId);
        Task AddItemToBasketAsync(CreateNewBasketItemRequest createNewBasketItemRequest);
        Task<Basket> GetBasketByUserIdAsync(int userId);
        Task RemoveBasketItemAsync(int basketId);
    }
}
