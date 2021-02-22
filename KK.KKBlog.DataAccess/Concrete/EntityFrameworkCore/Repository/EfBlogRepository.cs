using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KK.KKBlog.DataAccess.Concrete.EntityFrameworkCore.Context;
using KK.KKBlog.DataAccess.Interfaces;
using KK.KKBlog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace KK.KKBlog.DataAccess.Concrete.EntityFrameworkCore.Repository
{
    public class EfBlogRepository : EfGenericRepository<Blog>, IBlogDal
    {
        public async Task<List<Blog>> GetAllByCategoryIdAsync(int categoryId)
        {
            using var context = new KKBlogContext();
            return await context.Blogs.Join(context.CategoryBlogs, b => b.Id, cb => cb.BlogId, (blog, categoryBlog) => new
            {
                blog = blog,
                categoryBlog = categoryBlog
            }).Where(I => I.categoryBlog.CategoryId == categoryId).Select(I => new Blog
            {
                AppUser = I.blog.AppUser,
                AppUserId = I.blog.AppUserId,
                CategoryBlogs = I.blog.CategoryBlogs,
                Comments = I.blog.Comments,
                Description = I.blog.Description,
                Id = I.blog.Id,
                ImagePath = I.blog.ImagePath,
                ShortDescription = I.blog.ShortDescription,
                Title = I.blog.Title
            }).ToListAsync();
        }
        public async Task<List<Category>> GetCategoriesAsync(int blogId)
        {
            using var context = new KKBlogContext();
            return await context.Categories.Join(context.CategoryBlogs, c => c.Id, cb => cb.CategoryId, (category, categoryBlog) =>
                new
                {
                    category = category,
                    categoryBlog = categoryBlog
                }).Where(I => I.categoryBlog.BlogId == blogId).Select(I => new Category
            {
                Id = I.category.Id,
                Name = I.category.Name
            }).ToListAsync();
        }

        public async Task<List<Blog>> GetLastFiveAsync()
        {
            using var context = new KKBlogContext();
            return await context.Blogs.OrderByDescending(I => I.PostedTime).Take(5).ToListAsync();
        }
    }
}
