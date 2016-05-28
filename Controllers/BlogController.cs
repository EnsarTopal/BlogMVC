using BlogMVC.Context;
using BlogMVC.Models;
using Entity;
using Microsoft.AspNet.Identity;
using PagedList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMVC.Controllers
{
    public class BlogController : Controller
    {

        BlogContext _context = new BlogContext();


        public ActionResult Index(string keyword, int id = 0)
        {

            var _blogs = from i in _context.Blogs.Include("author")
                         where i.isPopular == true
                         select i;

            if (id != 0)
            {
                _blogs = _blogs.Where(i => i.Id == id);
            }


            if (!string.IsNullOrEmpty(keyword))
            {
                _blogs = _blogs.Where(i => i.Title.Contains(keyword) || i.Description.Contains(keyword) || i.author.Surname.Contains(keyword));
            }


            return View(_blogs.ToList());
        }


        [Authorize(Users = "ensartopal34@gmail.com")]
        public ActionResult List(int? page)
        {
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(_context.Blogs.OrderBy(i => i.Id).ToPagedList(pageNumber, pageSize));
        }


        public ActionResult Details(int id)
        {
            var _blog = (from i in _context.Blogs.Include("author")
                         where i.Id == id
                         select i).FirstOrDefault();


            return View(_blog);
        }


        [Authorize(Users = "ensartopal34@gmail.com")]
        public ActionResult Create()
        {
            ViewBag.Author = new SelectList(_context.Authors.ToList(), "Id", "Name", "Surname");
            ViewBag.Category = new SelectList(_context.Categories.ToList(), "Id", "Name");

            return View();
        }


        [HttpPost]
        [Authorize(Users = "ensartopal34@gmail.com")]
        public ActionResult Create(Blog entity)
        {
            try
            {

                entity.PublishDate = DateTime.Now;
                _context.Blogs.Add(entity);
                _context.SaveChanges();
                // TODO: Add insert logic here            

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View();
            }
        }


        [Authorize(Users = "ensartopal34@gmail.com")]
        public ActionResult Edit(int? id)
        {

            var blog = (from i in _context.Blogs
                        where i.Id == id
                        select i).FirstOrDefault();

            return View(blog);

        }


        [HttpPost]
        [Authorize(Users = "ensartopal34@gmail.com")]
        public ActionResult Edit(int? id, Blog blog)
        {
            try
            {
                var _blog = (from i in _context.Blogs
                             where i.Id == id
                             select i).FirstOrDefault();

                _blog.Image = blog.Image;
                _blog.Title = blog.Title;
                _blog.Description = blog.Description;
                _blog.Detail = blog.Detail;
                _blog.isPopular = blog.isPopular;
                _blog.isPublish = blog.isPublish;

                _context.SaveChanges();
                // TODO: Add update logic here


                return RedirectToAction("List");
            }
            catch
            {
                return View(blog);
            }
        }


        [Authorize(Users = "ensartopal34@gmail.com")]
        public ActionResult Delete(int id)
        {

            var entity = (from i in _context.Blogs
                          where i.Id == id
                          select i).FirstOrDefault();

            return View(entity);
        }


        [HttpPost]
        [Authorize(Users = "ensartopal34@gmail.com")]
        public ActionResult Delete(int id, Blog blog)
        {
            try
            {

                var sil = (from i in _context.Blogs
                           where i.Id == id
                           select i).FirstOrDefault();

                _context.Blogs.Remove(sil);
                _context.SaveChanges();
                // TODO: Add delete logic here

                return RedirectToAction("List");
            }
            catch
            {
                return View(blog);
            }
        }

    }

}
