using KidegaApp.DataTransferObjects.Responses;
using KidegaApp.Entities;

namespace KidegaApp.Mvc.Models
{
    public class DealOfWeek
    {
        public string Name { get; set; }
        public int DiscountRate { get; set; }
        public ProductDisplayResponse Product { get; set; }
        public void ApplyDiscount()
        {
            decimal discountAmount = (DiscountRate / 100m) * Product.Price;
            Product.Price -= discountAmount;
        }

    }
}
