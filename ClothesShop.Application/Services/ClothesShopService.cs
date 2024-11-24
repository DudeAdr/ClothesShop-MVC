using ClothesShop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Application.Services
{
    public class ClothesShopService : IClothesShopService
    {
        private IClothesShopRepository _clothesShopRepository;

        public ClothesShopService(IClothesShopRepository clothesShopRepository)
        {
            _clothesShopRepository = clothesShopRepository;
        }
        public async Task Create(Domain.Entities.ClothesShop clothesShop)
        {
            clothesShop.EncodeBrand();
            await _clothesShopRepository.Create(clothesShop);
        }
    }
}
