using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List() => View(repository.Products);
    }
}