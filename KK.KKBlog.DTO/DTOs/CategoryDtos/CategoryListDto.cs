using System;
using System.Collections.Generic;
using System.Text;
using KK.KKBlog.DTO.Interfaces;

namespace KK.KKBlog.DTO.DTOs.CategoryDtos
{
    public class CategoryListDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
