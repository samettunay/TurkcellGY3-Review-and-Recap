using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidegaApp.Entities
{
    // Sadece kitap satılmadığı için Product
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = "https://mybiros.com/wp-content/themes/qik/assets/images/no-image/No-Image-Found-400x264.png";
        public byte? Rating { get; set; }
        public string? BrandName { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public int? CampaignId { get; set; }
        public Campaign? Campaign { get; set; }
        public ICollection<BasketItem> BasketItems { get; set; }
    }
}
