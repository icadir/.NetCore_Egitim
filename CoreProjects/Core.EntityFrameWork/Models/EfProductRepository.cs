using System.Linq;

namespace Core.EntityFrameWork.Models
{
    public class EfProductRepository : IProductRepository
    {
        private ApplicationDbContext _context;

        public EfProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Product GetById(int productId)
        {
            return  _context.Products.FirstOrDefault(x => x.ProductId == productId);
        }

        public IQueryable<Product> Products => _context.Products;


        public void CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
    }
}
