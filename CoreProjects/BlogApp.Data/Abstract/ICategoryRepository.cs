﻿using System.Linq;
using BlogApp.Entity;

namespace BlogApp.Data.Abstract
{
    public interface ICategoryRepository
    {
        Category GetById(int categoryId);
        IQueryable<Category> GetAll();
        void AddCategory(Category entity);
        void UpdateCateogry(Category entity);
        void SaveCateogry(Category entity);
        void DeteleCategory(int categoryId);
    }
}
