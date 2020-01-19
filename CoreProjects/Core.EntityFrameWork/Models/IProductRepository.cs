using System.Linq;

namespace Core.EntityFrameWork.Models
{
    public interface IProductRepository
    {
        Product GetById(int productId);
        IQueryable<Product> Products { get; }
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productId);
    }
}
