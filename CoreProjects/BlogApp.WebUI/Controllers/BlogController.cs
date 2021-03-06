﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Data.Abstract;
using BlogApp.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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

        public IActionResult Index(int? id, string q)
        {
            var query = _blogRepository.GetAll().Where(x => x.isApproved);
            if (id != null)
            {
                query = query.Where(x => x.CategoryId == id);
            }

            if (!string.IsNullOrEmpty(q))
            {
                query = query.Where(x => EF.Functions.Like(x.Title, "%" + q + "%") || EF.Functions.Like(x.Description, "%" + q + "%") || EF.Functions.Like(x.Body, "%" + q + "%") );
            }

            return View(query.OrderByDescending(x => x.Date));
        }

        public IActionResult List()
        {
            return View(_blogRepository.GetAll());
        }

        [HttpGet]
        public IActionResult AddOrUpdate(int id)
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

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_blogRepository.GetById(id));
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int blogId)
        {
            _blogRepository.DeteleBlog(blogId);
            TempData["message"] = $"{blogId} numaralı kayıt edildi.";
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_blogRepository.GetById(id));
        }
    }
}