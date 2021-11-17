using BusinessLayer.Concrate;
using DataAccessLayer.Concrate.EntityFramework;
using EntityLayer.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using BusinessLayer2.ValidationRules;
using FluentValidation.Results;
using System.IO;

namespace NLayerBlogProje.Controllers.AdminPanel
{
    [Authorize]
    public class AdminBlogController : Controller
    {
        // GET: AdminBlog
        BlogManeger blogManeger = new BlogManeger(new EFBlogDal());
        BlogValidator validationRules = new BlogValidator();
        
        public ActionResult AdminBlog(int p=1)
        {
            var values = blogManeger.ListBL().ToPagedList(p,6);
            return View(values);
        }
        [HttpGet]
        public ActionResult AddBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBlog(Blog blog)
        {
            ValidationResult result = validationRules.Validate(blog);
            
                
                if (result.IsValid)
                {
                    string dosyaAdi = Path.GetFileName(Request.Files[0].FileName);
                    string uzanti = Path.GetExtension(Request.Files[0].FileName);
                    string link = "/Image/" + dosyaAdi;
                    Request.Files[0].SaveAs(Server.MapPath(link));
                    blog.Img = link;

                    blogManeger.InsertBL(blog);
                    return RedirectToAction("AdminBlog");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    }
                }
                


            
            return View();

        }
        public ActionResult DeleteBlog(int id)
        {
            var value = blogManeger.GetBL(id);
            blogManeger.DeleteBL(value);
            return RedirectToAction("AdminBlog");
        }
        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            var values = blogManeger.GetBL(id);
           
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateBlog(Blog blog)
        {
            
            ValidationResult result = validationRules.Validate(blog);
            string dosyaAdi = Path.GetFileName(Request.Files[0].FileName);
            if (dosyaAdi != "")
            {

                string uzanti = Path.GetExtension(Request.Files[0].FileName);
                string link = "/Image/" + dosyaAdi;
                Request.Files[0].SaveAs(Server.MapPath(link));
                blog.Img = link;
            }
            if (result.IsValid)
            {
               

                blogManeger.UpdateBL(blog);
                return RedirectToAction("AdminBlog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
           
        }
    }
}