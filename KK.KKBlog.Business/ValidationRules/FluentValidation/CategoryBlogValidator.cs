using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using KK.KKBlog.DTO.DTOs.CategoryBlogDtos;

namespace KK.KKBlog.Business.ValidationRules.FluentValidation
{
    public class CategoryBlogValidator : AbstractValidator<CategoryBlogDto>
    {
        public CategoryBlogValidator()
        {
            RuleFor(I => I.CategoryId).InclusiveBetween(0, int.MaxValue).WithMessage("Kategori Id Boş geçilemez.");
            RuleFor(I => I.BlogId).InclusiveBetween(0, int.MaxValue).WithMessage("Blog Id Boş geçilemez.");
        }
    }
}
