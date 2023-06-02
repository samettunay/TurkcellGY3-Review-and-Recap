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
        public decimal? Price { get; set; }
        public string ImageUrl { get; set; } = "https://loremflickr.com/320/240";
        public byte? Rating { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
