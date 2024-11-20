using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Infrastructure.Persistence
{
    public class ClothesShopDbContext : DbContext
    {
        public ClothesShopDbContext(DbContextOptions<ClothesShopDbContext> options) : base(options) 
        {
        
        }
        public DbSet<Domain.Entities.ClothesShop> ClothesShop { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Entities.ClothesShop>()
                .OwnsOne(c => c.ItemDetails);
        }
    }
}
