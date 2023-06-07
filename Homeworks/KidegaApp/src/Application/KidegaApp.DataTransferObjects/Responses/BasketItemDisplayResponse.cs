using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidegaApp.DataTransferObjects.Responses
{
    public class BasketItemDisplayResponse
    {
        public int Id { get; set; }
        public int BasketId { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
    }
}
