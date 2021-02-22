using AutoMapper;
using KK.KKBlog.DTO.DTOs.AppUserDtos;
using KK.KKBlog.DTO.DTOs.BlogDtos;
using KK.KKBlog.DTO.DTOs.CommentDtos;
using KK.KKBlog.DTO.DTOs.CategoryDtos;
using KK.KKBlog.Entities.Concrete;
using KK.KKBlog.WebApi.Models;

namespace KK.KKBlog.WebApi.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<BlogListDto, Blog>();
            CreateMap<Blog, BlogListDto>();

            CreateMap<BlogUpdateModel, Blog>();
            CreateMap<Blog, BlogUpdateModel>();

            CreateMap<BlogAddModel, Blog>();
            CreateMap<Blog, BlogAddModel>();

            CreateMap<CategoryAddDto, Category>();
            CreateMap<Category, CategoryAddDto>();

            CreateMap<AppUserAddDto, AppUser>();
            CreateMap<AppUser, AppUserAddDto>();

            CreateMap<CategoryListDto, Category>();
            CreateMap<Category, CategoryListDto>();

            CreateMap<CategoryUpdateDto, Category>();
            CreateMap<Category, CategoryUpdateDto>();

            CreateMap<Comment, CommentListDto>();
            CreateMap<CommentListDto, Comment>();

            CreateMap<CommentAddDto, Comment>();
            CreateMap<Comment, CommentAddDto>();

            CreateMap<AppUserDto, AppUser>();
            CreateMap<AppUser, AppUserDto>();
        }
    }
}
