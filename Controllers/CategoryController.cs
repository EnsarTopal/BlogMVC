using BlogMVC.Context;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;
using System.Web.Mvc;

namespace BlogMVC.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        BlogContext _context = new BlogContext();

        [Authorize(Users = "ensartopal34@gmail.com")]
        public ActionResult Index(int? page)
        {
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(_context.Categories.OrderBy(i => i.Id).ToPagedList(pageNumber,pageSize));
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            var category = (from i in _context.Categories
                            where i.Id == id
                            select i).FirstOrDefault();
            return View(category);
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }



        public ActionResult GetAll()
        {

            var category = (from i in _context.Categories
                            select i).ToList();
            return PartialView(category);
        }



        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(Category category)
        {
            try
            {

                _context.Categories.Add(category);
                _context.SaveChanges();

                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {

            var edit = (from i in _context.Categories
                        where i.Id == id
                        select i).FirstOrDefault();

            return View();
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Category category)
        {
            try
            {

                var edit = (from i in _context.Categories
                            where i.Id == id
                            select i).FirstOrDefault();
                _context.SaveChanges();
                // TODO: Add update logic here

                return RedirectToAction("List");
            }
            catch
            {
                return View(category);
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Category category)
        {
            try
            {

                var remove = (from i in _context.Categories
                              where i.Id == id
                              select i).FirstOrDefault();
                _context.Categories.Remove(remove);
                _context.SaveChanges();

                // TODO: Add delete logic here

                return RedirectToAction("List");
            }
            catch
            {
                return View(category);
            }
        }
    }
}
