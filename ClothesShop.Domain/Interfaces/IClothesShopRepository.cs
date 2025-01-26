using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Domain.Interfaces
{
    public interface IClothesShopRepository
    {
        Task Create(Domain.Entities.ClothesShop clothesShop);
        Task<Domain.Entities.ClothesShop?> GetByName(string name);
        Task<IEnumerable<Domain.Entities.ClothesShop>> GetAll();
    }
}
