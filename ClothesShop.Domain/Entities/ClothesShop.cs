using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Domain.Entities
{
    public class ClothesShop
    {
        public int Id { get; set; }
        public string Brand { get; set; } = default!;
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
        public ClothesShopItemDetails ItemDetails { get; set; } = default!;
        public string EncodedBrand { get; private set; } = default!;
        public void EncodeBrand() => EncodedBrand = Brand.ToLower().Replace(" ", "-");
    }
}