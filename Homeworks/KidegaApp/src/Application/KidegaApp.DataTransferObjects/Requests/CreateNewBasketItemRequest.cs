using KidegaApp.DataTransferObjects.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidegaApp.DataTransferObjects.Requests
{
    public class CreateNewBasketItemRequest
    {
        public int ProductId { get; set; }
        public int BasketId { get; set; }
        public int Quantity { get; set; }
    }
}
