using ClothesShop.Application.ClothesShop;
using ClothesShop.Application.Mappings;

namespace ClothesShop.Application.Services
{
    public interface IClothesShopService
    {
        Task Create(ClothesShopDto clothesShop);
    }
}