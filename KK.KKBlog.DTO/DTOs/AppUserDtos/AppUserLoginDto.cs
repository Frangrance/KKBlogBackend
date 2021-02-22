using System;
using System.Collections.Generic;
using System.Text;
using KK.KKBlog.DTO.Interfaces;

namespace KK.KKBlog.DTO.DTOs.AppUserDtos
{
    public class AppUserLoginDto : IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
