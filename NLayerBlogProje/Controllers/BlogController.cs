using BusinessLayer.Concrate;
using DataAccessLayer.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NLayerBlogProje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        BlogManeger blogManeger = new BlogManeger(new EFBlogDal());
        public PartialViewResult BlogIndex()
        {
            var values = blogManeger.ListBL();
            return PartialView(values);
        }
        public ActionResult BlogDetails(int id)
        {
            var values = blogManeger.GetBL(id);
            return View(values);
        }
        public PartialViewResult BlogDetailsLastWord()
        {
            var values = blogManeger.GetLastWordBL();
            return PartialView(values);
        }
    }
}