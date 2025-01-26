using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Application.ClothesShop
{
    public class ClothesShopDto
    {
        public string Brand { get; set; }
        public string Description { get; set; }
        public string About { get; set; }
        public string? Name { get; set; }
        public string? Size { get; set; }
        public string? Colour { get; set; }
        public int? Price { get; set; }
        public string? EncodedBrand { get; set; }
    }
}
