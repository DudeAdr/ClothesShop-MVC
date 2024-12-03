using AutoMapper;
using ClothesShop.Application.ClothesShop;
using ClothesShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Application.Mappings
{
    public class ClothesShopMappingProfile : Profile
    {
        public ClothesShopMappingProfile()
        {
            CreateMap<ClothesShopDto, Domain.Entities.ClothesShop>()
                .ForMember(e => e.ItemDetails, opt => opt.MapFrom(src => new ClothesShopItemDetails()
                {
                    Name = src.Name,
                    Size = src.Size,
                    Colour = src.Colour,
                    Price = src.Price,
                }));
        }
    }
}
