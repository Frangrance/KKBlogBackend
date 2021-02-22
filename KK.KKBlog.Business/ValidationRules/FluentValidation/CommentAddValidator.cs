using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using FluentValidation;
using KK.KKBlog.DTO.DTOs.CommentDtos;

namespace KK.KKBlog.Business.ValidationRules.FluentValidation
{
    public class CommentAddValidator : AbstractValidator<CommentAddDto>
    {
        public CommentAddValidator()
        {
            RuleFor(I => I.AuthorName).NotEmpty().WithMessage("Ad alanı boş bırakılamaz.");
            RuleFor(I => I.AuthorEmail).NotEmpty().WithMessage("Mail alanı boş bırakılamaz.");
            RuleFor(I => I.Description).NotEmpty().WithMessage("Yorum alanı boş bırakılamaz.");
           

        }

    }
}
