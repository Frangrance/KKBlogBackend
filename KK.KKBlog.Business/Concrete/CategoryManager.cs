﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using KK.KKBlog.Business.Interfaces;
using KK.KKBlog.DataAccess.Interfaces;
using KK.KKBlog.Entities.Concrete;

namespace KK.KKBlog.Business.Concrete
{
    public class CategoryManager: GenericManager<Category>,ICategoryService
    {
        private readonly IGenericDal<Category> _genericDal;
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(IGenericDal<Category> genericDal,ICategoryDal categoryDal) : base(genericDal)
        {
            _genericDal = genericDal;
            _categoryDal = categoryDal;
        }

        public async Task<List<Category>> GetAllSortedByIdAsync()
        {
            return await _genericDal.GetAllAsync(I => I.Id);
        }

        public async Task<List<Category>> GetAllWithCategoryBlogsAsync()
        {
            return await _categoryDal.GetAllWithCategoryBlogsAsync();
        }
    }
}
