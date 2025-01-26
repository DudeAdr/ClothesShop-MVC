using AutoMapper;
using ClothesShop.Application.ClothesShop;
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
        private IMapper _mapper;

        public ClothesShopService(IClothesShopRepository clothesShopRepository, IMapper mapper)
        {
            _clothesShopRepository = clothesShopRepository;
            _mapper = mapper;
        }
        public async Task Create(ClothesShopDto clothesShopDto)
        {
            var clothesShop = _mapper.Map<Domain.Entities.ClothesShop>(clothesShopDto);

            clothesShop.EncodeBrand();
            await _clothesShopRepository.Create(clothesShop);
        }

        public async Task<IEnumerable<ClothesShopDto>> GetAll()
        {
            var clothesShops = await _clothesShopRepository.GetAll();
            var dtos = _mapper.Map<IEnumerable<ClothesShopDto>>(clothesShops);
            return dtos;
        }
    }
}
