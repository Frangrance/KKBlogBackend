using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using KK.KKBlog.Entities.Concrete;

namespace KK.KKBlog.DataAccess.Interfaces
{
    public interface IBlogDal:IGenericDal<Blog>
    {
        Task<List<Blog>> GetAllByCategoryIdAsync(int categoryId);
        Task<List<Category>> GetCategoriesAsync(int blogId);
        Task<List<Blog>> GetLastFiveAsync();
    }
}
