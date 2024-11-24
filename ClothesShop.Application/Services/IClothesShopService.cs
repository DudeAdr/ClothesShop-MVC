namespace ClothesShop.Application.Services
{
    public interface IClothesShopService
    {
        Task Create(Domain.Entities.ClothesShop clothesShop);
    }
}