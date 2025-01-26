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

            CreateMap<Domain.Entities.ClothesShop, ClothesShopDto>()
                .ForMember(dto => dto.Name, opt => opt.MapFrom(src => src.ItemDetails.Name))
                .ForMember(dto => dto.Size, opt => opt.MapFrom(src => src.ItemDetails.Size))
                .ForMember(dto => dto.Colour, opt => opt.MapFrom(src => src.ItemDetails.Colour))
                .ForMember(dto => dto.Price, opt => opt.MapFrom(src => src.ItemDetails.Price));
        }
    }
}
