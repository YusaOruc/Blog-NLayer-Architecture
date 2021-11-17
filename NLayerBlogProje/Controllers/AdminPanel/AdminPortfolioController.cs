using BusinessLayer.Concrate;
using DataAccessLayer.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using EntityLayer.Concrate.EntityFramework;
using BusinessLayer2.ValidationRules;
using FluentValidation.Results;
using System.IO;

namespace NLayerBlogProje.Controllers.AdminPanel
{
    [Authorize]
    public class AdminPortfolioController : Controller
    {
        // GET: AdminPortfolio
        MyPortfolioManeger maneger = new MyPortfolioManeger(new EFMyPortfolioDal());
        PortfolioValidator validationRules = new PortfolioValidator();
        public ActionResult AdminPortfolio(int p = 1)
        {
            var values = maneger.ListBL().ToPagedList(p,5);
            return View(values);
        }
        [HttpGet]
        public ActionResult AddPortfolio()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPortfolio(MyPortfolio myPortfolio)
        {
            ValidationResult result = validationRules.Validate(myPortfolio);

            
                
                if (result.IsValid)
                {
                    string dosyaAdi = Path.GetFileName(Request.Files[0].FileName);
                    string uzanti = Path.GetExtension(Request.Files[0].FileName);
                    string link = "/Image/Portfolio/" + dosyaAdi;
                    Request.Files[0].SaveAs(Server.MapPath(link));
                    myPortfolio.Img = link;

                    maneger.InsertBL(myPortfolio);
                    return RedirectToAction("AdminPortfolio");
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
        public ActionResult DeletePortfolio(int id)
        {
            var values = maneger.GetBL(id);
            maneger.DeleteBL(values);
            return RedirectToAction("AdminPortfolio");

        }
        [HttpGet]
        public ActionResult EditPortfolio(int id)
        {
            var values = maneger.GetBL(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult EditPortfolio(MyPortfolio portfolio)
        {
            
            ValidationResult result = validationRules.Validate(portfolio);
            string dosyaAdi = Path.GetFileName(Request.Files[0].FileName);
            if (dosyaAdi != "")
            {

                string uzanti = Path.GetExtension(Request.Files[0].FileName);
                string link = "/Image/" + dosyaAdi;
                Request.Files[0].SaveAs(Server.MapPath(link));
                portfolio.Img = link;
            }
           
            
            maneger.UpdateBL(portfolio);
            return RedirectToAction("AdminPortfolio");


        }
    }
}