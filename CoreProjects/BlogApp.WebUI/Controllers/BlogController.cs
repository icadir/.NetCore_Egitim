using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Data.Abstract;
using BlogApp.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Remotion.Linq.Utilities;

namespace BlogApp.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private IBlogRepository _blogRepository;
        private ICategoryRepository _categoryRepository;

        public BlogController(IBlogRepository repository, ICategoryRepository categoryRepository)
        {
            _blogRepository = repository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View(_blogRepository.GetAll());
        }

        //[HttpGet]
        //public IActionResult Create()
        //{
        //    ViewBag.Categories = new SelectList(_categoryRepository.GetAll(), "CategoryId", "Name");

        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Create(Blog entity)
        //{
        //    entity.Date = DateTime.Now;

        //    if (ModelState.IsValid)
        //    {
        //        _blogRepository.AddBlog(entity);
        //     return  RedirectToAction("List");
        //    }
        //    ViewBag.Categories = new SelectList(_categoryRepository.GetAll(), "CategoryId", "Name");
        //    return View(entity);
        //}

        //[HttpGet]
        //public IActionResult Edit(int id)
        //{
        //    ViewBag.Categories = new SelectList(_categoryRepository.GetAll(), "CategoryId", "Name");
        //    return View(_blogRepository.GetById(id));
        //}

        //[HttpPost]
        //public IActionResult Edit(Blog entity)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        TempData["message"] = $"{entity.Title} Güncellendi.";
        //        _blogRepository.UpdateBlog(entity);
        //        return RedirectToAction("List");
        //    }
        //    ViewBag.Categories = new SelectList(_categoryRepository.GetAll(), "CategoryId", "Name");

        //    return View(entity);
        //}

        [HttpGet]
        public IActionResult AddOrUpdate(int? id)
        {
            ViewBag.Categories = new SelectList(_categoryRepository.GetAll(), "CategoryId", "Name");

            if (id == null)
            {
                return View(new Blog());
            }
            else
            {
                return View(_blogRepository.GetById((int)id));
            }
        }

        [HttpPost]
        public IActionResult AddOrUpdate(Blog entity)
        {
            if (ModelState.IsValid)
            {
                _blogRepository.SaveBlog(entity);
                TempData["message"] = $"{entity.Title} kayıt edildi.";
                return RedirectToAction("List");
            }
            ViewBag.Categories = new SelectList(_categoryRepository.GetAll(), "CategoryId", "Name");
            return View(entity);
        }

    }
}