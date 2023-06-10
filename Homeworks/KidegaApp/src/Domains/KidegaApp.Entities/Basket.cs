using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidegaApp.Entities
{
    public class Basket : IEntity
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public ICollection<BasketItem>? BasketItems { get; set;}
    }
}
