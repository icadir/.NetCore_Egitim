using Core.EntityFrameWork.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core.EntityFrameWork.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index() => View();

        public IActionResult List()
        {
            return View(repository.Products);
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Product product)
        {
            repository.CreateProduct(product);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(repository.GetById(id));
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            repository.UpdateProduct(product);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int productId)
        {
            repository.DeleteProduct(productId);
            return RedirectToAction("List");
        }
    }
}