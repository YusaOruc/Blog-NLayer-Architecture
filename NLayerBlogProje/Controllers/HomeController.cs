

using BusinessLayer.Concrate;

using DataAccessLayer.Concrate.EntityFramework;
using EntityLayer.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NLayerBlogProje.Controllers
{
    
    public class HomeController : Controller
    {
        // GET: Home
        HomeManeger homeManeger = new HomeManeger(new EFHomeDal());
        MessageManeger messageManeger = new MessageManeger(new EFMessageDal());
        public ActionResult HomeIndex()
        {
            var value = homeManeger.ListBL();
            return View(value);
        }
        [HttpPost]
        public ActionResult AddMessage(Message message)
        {

            messageManeger.InsertBL(message);
            return RedirectToAction("HomeIndex");
        }
    }
}