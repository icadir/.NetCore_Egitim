using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlogApp.Data.Abstract;
using BlogApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data.Concrete.EfCore
{
    public class EfBlogRepository:IBlogRepository
    {
        private BlogContext context;

        public EfBlogRepository(BlogContext context)
        {
            this.context = context;
        }
        public Blog GetById(int blogId)
        {
            return context.Blogs.FirstOrDefault(x => x.BlogId == blogId);
        }

        public IQueryable<Blog> GetAll()
        {
            return context.Blogs;
        }

        public void AddCategory(Blog entity)
        {
            context.Blogs.Add(entity);
            context.SaveChanges();
        }

        public void UpdateCateogry(Blog entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeteleCategory(int blogId)
        {
            var blog = context.Blogs.First(x => x.BlogId == blogId);

            if (blog != null)
            {
                context.Blogs.Remove(blog);
                context.SaveChanges();
            }
        }
      

    }
}
