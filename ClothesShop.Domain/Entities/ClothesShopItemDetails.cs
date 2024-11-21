using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Domain.Entities
{
    public class ClothesShopItemDetails
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Size { get; set; }
        public string? Colour { get; set; }
        public double Price { get; set; }

    }
}
