using ClothesShop.Domain.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Application.ClothesShop
{
    public class ClothesShopDtoValidator : AbstractValidator<ClothesShopDto>
    {
        public ClothesShopDtoValidator(IClothesShopRepository repository)
        {
            RuleFor(c => c.Brand)
                .NotEmpty()
                .MinimumLength(2).WithMessage("Name should have at least 2 characters!")
                .MaximumLength(30).WithMessage("Name should have maximum of 30 characters!")
                .Custom((value, context) =>
                {
                    var existingClothesShop = repository.GetByName(value).Result;
                    if (existingClothesShop != null) 
                    {
                        context.AddFailure($"Brand called {value} already exists and it is not unique");
                    }
                });

            RuleFor(c => c.Name)
                .NotEmpty()
                .MinimumLength(2).WithMessage("Name should have at least 2 characters!")
                .MaximumLength(50).WithMessage("Name should have maximum of 50 characters!");

            RuleFor(c => c.Description)
                .NotEmpty().WithMessage("Please enter description!");


        }
    }
}
