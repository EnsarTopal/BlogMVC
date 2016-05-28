using BlogMVC.Context;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMVC.Controllers
{
    public class CommentController : Controller
    {
        BlogContext _context = new BlogContext();

        public ActionResult add_comment()
        {
            return PartialView();
        }

        public ActionResult Get_all()
        {
            var yorumlar = (from i in _context.Comments
                            select i).ToList();

            return PartialView(yorumlar);
        }

        [HttpPost]
        public ActionResult add_comment(Comment entity)
        {
            try
            {
                _context.Comments.Add(entity);
                _context.SaveChanges();                
                ViewBag.basarili = "New comment is successfully added.<meta http-equiv='refresh' content='2'; URL = '' />";
                return PartialView();
            }
            catch (Exception)
            {

                return PartialView();
            }
                        
        }

        public ActionResult Comment_list(int id)
        {
            var bul = from i in _context.Comments where i.Blog_Id == id select i;

            ViewBag.toplamYorum = bul.Count();
            return PartialView(bul.ToList());
            
        }

    }
}