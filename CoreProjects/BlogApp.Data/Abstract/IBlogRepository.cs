using System.Linq;
using BlogApp.Entity;

namespace BlogApp.Data.Abstract
{
    public interface IBlogRepository
    {
        Blog GetById(int blogId);
        IQueryable<Blog> GetAll();
        void AddCategory(Blog entity);
        void UpdateCateogry(Blog entity);
        void DeteleCategory(int blogId);
    }
}
