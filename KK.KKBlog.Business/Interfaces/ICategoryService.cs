using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using KK.KKBlog.Entities.Concrete;

namespace KK.KKBlog.Business.Interfaces
{
    public interface ICategoryService : IGenericService<Category>
    {
        Task<List<Category>> GetAllSortedByIdAsync();
        Task<List<Category>> GetAllWithCategoryBlogsAsync();
    }
}
