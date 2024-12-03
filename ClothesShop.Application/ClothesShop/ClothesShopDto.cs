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
        [Required]
        [StringLength(40,MinimumLength = 2)]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Please insert brand")]
        public string Description { get; set; }
        public string About { get; set; }
        [StringLength(50,MinimumLength =2)]
        public string? Name { get; set; }
        public string? Size { get; set; }
        public string? Colour { get; set; }
        public int? Price { get; set; }
        public string? EncodedName { get; set; }
    }
}
