using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlogApp.Data.Abstract;
using BlogApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data.Concrete.EfCore
{
    public class EfCateogryRepository : ICategoryRepository
    {
        private BlogContext context;

        public EfCateogryRepository(BlogContext context)
        {
            this.context = context;
        }

        public Category GetById(int categoryId)
        {
            return context.Categories.FirstOrDefault(x => x.CategoryId == categoryId);
        }

        public IQueryable<Category> GetAll()
        {
            return context.Categories;
        }

        public void AddCategory(Category entity)
        {
            context.Categories.Add(entity);
            context.SaveChanges();
        }

        public void UpdateCateogry(Category entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void SaveCateogry(Category entity)
        {
            if (entity.CategoryId == 0)
            {
                context.Categories.Add(entity);
            }
            else
            {
                var category = GetById(entity.CategoryId);
                if (category != null)
                {
                    category.Name = entity.Name;
                }
            }
            context.SaveChanges();
        }

        public void DeteleCategory(int categoryId)
        {
            var category = context.Categories.First(x => x.CategoryId == categoryId);

            if (category!=null)
            {
                context.Categories.Remove(category);
                context.SaveChanges();
            }
        }
    }
}
