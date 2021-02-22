using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using KK.KKBlog.DTO.DTOs.AppUserDtos;

namespace KK.KKBlog.Business.ValidationRules.FluentValidation
{
   public class AppUserLoginValidator : AbstractValidator<AppUserLoginDto>
    {
        public AppUserLoginValidator()
        {
            RuleFor(I => I.UserName).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez.");
            RuleFor(I => I.Password).NotEmpty().WithMessage("Parola boş geçilemez.");

        }
    }
}
