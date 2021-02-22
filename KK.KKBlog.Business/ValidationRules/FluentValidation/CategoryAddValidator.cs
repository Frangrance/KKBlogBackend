using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using FluentValidation;
using KK.KKBlog.DTO.DTOs.CategoryDtos;

namespace KK.KKBlog.Business.ValidationRules.FluentValidation
{
    public class CategoryAddValidator:AbstractValidator<CategoryAddDto>
    {
        public CategoryAddValidator()
        {
            RuleFor(I => I.Name).NotEmpty().WithMessage("Kategori alanı boş geçilemez.");
        }
    }
}
