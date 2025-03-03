﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using KK.KKBlog.DataAccess.Concrete.EntityFrameworkCore.Context;
using KK.KKBlog.DataAccess.Interfaces;
using KK.KKBlog.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KK.KKBlog.DataAccess.Concrete.EntityFrameworkCore.Repository
{
    public class EfGenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class, ITable, new()
    {
        public async Task<List<TEntity>> GetAllAsync()
        {
            using var context = new KKBlogContext();
            return await context.Set<TEntity>().ToListAsync();
        }
        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter)
        {
            using var context = new KKBlogContext();
            return await context.Set<TEntity>().Where(filter).ToListAsync();
        }
        public async Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, bool>> filter,Expression<Func<TEntity,TKey>> keySelector)
        {
            using var context = new KKBlogContext();
            return await context.Set<TEntity>().Where(filter).OrderByDescending(keySelector).ToListAsync();
        }
        public async Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, TKey>> keySelector)
        {
            using var context = new KKBlogContext();
            return await context.Set<TEntity>().OrderByDescending(keySelector).ToListAsync();
        }
        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            using var context = new KKBlogContext();
            return await context.Set<TEntity>().FirstOrDefaultAsync(filter);
        }

        public async Task<TEntity> FindByIdAsync(int id)
        {
            using var context = new KKBlogContext();
            return await context.FindAsync<TEntity>(id);
        }

        public async Task AddAsync(TEntity entity)
        {
            using var context = new KKBlogContext();
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
        }
        public async Task UpdateAsync(TEntity entity)
        {
            using var context = new KKBlogContext();
            context.Update(entity);
            await context.SaveChangesAsync();

        }
        public async Task RemoveAsync(TEntity entity)
        {
            using var context = new KKBlogContext();
            context.Remove(entity);
            await context.SaveChangesAsync();
        }
    }
}