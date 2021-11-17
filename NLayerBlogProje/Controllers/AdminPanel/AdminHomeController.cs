using BusinessLayer.Concrate;
using BusinessLayer2.ValidationRules;
using DataAccessLayer.Concrate.EntityFramework;
using EntityLayer.Concrate.EntityFramework;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NLayerBlogProje.Controllers.AdminPanel
{
    [Authorize]
    public class AdminHomeController : Controller
    {
        // GET: AdminHome
        HomeManeger homeManeger = new HomeManeger(new EFHomeDal());
        
        public ActionResult AdminHome()
        {
            var values = homeManeger.ListBL();
            return View(values);
        }
        [HttpGet]
        public ActionResult EditHome(int id)
        {
            var values = homeManeger.GetBL(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult EditHome(Home home)
        {
            HomeValidator validationRules = new HomeValidator();
            ValidationResult result = validationRules.Validate(home);

            if (result.IsValid)
            {
                homeManeger.UpdateBL(home);
                return RedirectToAction("AdminHome");
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