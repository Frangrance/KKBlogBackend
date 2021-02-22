using FluentValidation;
using KK.KKBlog.Business.Concrete;
using KK.KKBlog.Business.Interfaces;
using KK.KKBlog.Business.Tools.JWTTool;
using KK.KKBlog.Business.Tools.LogTool;
using KK.KKBlog.Business.ValidationRules.FluentValidation;
using KK.KKBlog.DataAccess.Concrete.EntityFrameworkCore.Repository;
using KK.KKBlog.DataAccess.Interfaces;
using KK.KKBlog.DTO.DTOs.AppUserDtos;
using KK.KKBlog.DTO.DTOs.CategoryBlogDtos;
using KK.KKBlog.DTO.DTOs.CategoryDtos;
using KK.KKBlog.DTO.DTOs.CommentDtos;
using KK.KKBlog.Entities.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace KK.KKBlog.Business.DependcyResolvers.MicrosoftIoC
{
    public static class CustomIoCExtension
    {
        public static void AddDependencies(this IServiceCollection services) // bağımlılıları ekleme
        {
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<IBlogService, BlogManager>();
            services.AddScoped<IBlogDal, EfBlogRepository>();

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryRepository>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserRepository>();

            services.AddScoped<IJwtService, JwtManager>();
            services.AddScoped<ICustomLogger, NLogAdapter>();

            services.AddTransient<IValidator<AppUserLoginDto>,AppUserLoginValidator>();
            services.AddTransient<IValidator<CategoryAddDto>, CategoryAddValidator>();
            services.AddTransient<IValidator<CategoryBlogDto>, CategoryBlogValidator>();
            services.AddTransient<IValidator<CategoryUpdateDto>, CategoryUpdateValidator>();
            services.AddTransient<IValidator<CommentAddDto>, CommentAddValidator>();

            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal,EfCommentRepository>();
        }
    }
}
