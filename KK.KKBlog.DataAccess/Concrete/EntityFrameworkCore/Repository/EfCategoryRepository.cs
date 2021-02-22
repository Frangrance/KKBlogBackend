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
    public class EfCategoryRepository : EfGenericRepository<Category>,ICategoryDal
    {
        public async Task<List<Category>> GetAllWithCategoryBlogsAsync()
        {
            using var context = new KKBlogContext();
            return await context.Categories.OrderByDescending(I=>I.Id).Include(I => I.CategoryBlogs).ToListAsync();

        }
    }
}
