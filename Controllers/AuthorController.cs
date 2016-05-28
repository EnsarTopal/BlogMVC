using BlogMVC.Context;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMVC.Controllers
{
    public class AuthorController : Controller
    {
        BlogContext _context = new BlogContext();

        [Authorize(Users = "ensartopal34@gmail.com")]
        public ActionResult List()
        {
            return View(_context.Authors.ToList());
        }

        // GET: Author/Details/5
        public ActionResult Details(int id)
        {
            var author = (from i in _context.Authors
                          where i.Id == id
                          select i).FirstOrDefault();
            return View(author);
        }

        public ActionResult All()
        {
            var author = (from i in _context.Authors
                            select i).ToList();
            return PartialView(author);
        }

        // GET: Author/Create
        public ActionResult Create()
        {
            return View();
        }

        [Authorize(Users ="ensartopal34@gmail.com")]
        [HttpPost]
        public ActionResult Create(Author Author)
        {
            try
            {
                _context.Authors.Add(Author);
                _context.SaveChanges();

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        // GET: Author/Edit/5
        public ActionResult Edit(int id)
        {
            var edit = (from i in _context.Authors
                        where i.Id == id
                        select i).FirstOrDefault();
            return View();
        }

        // POST: Author/Edit/5
        [HttpPost]
        public ActionResult Edit(int id,Author entity)
        {
            try
            {
                var edit = (from i in _context.Authors
                            where i.Id == id
                            select i).FirstOrDefault();
                _context.SaveChanges();

                return RedirectToAction("List");
            }
            catch
            {
                return View(entity);
            }
        }

        // GET: Author/Delete/5
        public ActionResult Delete(int id)
        {
            var fgh = (from i in _context.Authors
                       where i.Id == id
                       select i).FirstOrDefault();
            return View(fgh);
        }

        // POST: Author/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Author entity)
        {
            try
            {
                var remove = (from i in _context.Authors
                              where i.Id == id
                              select i).FirstOrDefault();
                _context.Authors.Remove(remove);
                _context.SaveChanges();

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }
    }
}
