using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using KK.KKBlog.DTO.DTOs.CategoryDtos;

namespace KK.KKBlog.Business.ValidationRules.FluentValidation
{
    public class CategoryUpdateValidator:AbstractValidator<CategoryUpdateDto>
    {
        public CategoryUpdateValidator()
        {
            RuleFor(I => I.Id).InclusiveBetween(0, int.MaxValue).WithMessage("Id alanı boş geçilemez.");
            RuleFor(I => I.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez.");
        }
    }
}
