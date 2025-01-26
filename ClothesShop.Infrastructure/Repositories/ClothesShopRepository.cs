using ClothesShop.Domain.Interfaces;
using ClothesShop.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Infrastructure.Repositories
{
    internal class ClothesShopRepository : IClothesShopRepository
    {
        private ClothesShopDbContext _dbContext;

        public ClothesShopRepository(ClothesShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Create(Domain.Entities.ClothesShop clothesShop)
        {
            _dbContext.Add(clothesShop);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Domain.Entities.ClothesShop>> GetAll()
        {
            return await _dbContext.ClothesShop.ToListAsync();
        }

        public Task<Domain.Entities.ClothesShop?> GetByName(string name)
        {
            return _dbContext.ClothesShop.FirstOrDefaultAsync(c => c.Brand.ToLower() == name.ToLower());
        }

    }
}
