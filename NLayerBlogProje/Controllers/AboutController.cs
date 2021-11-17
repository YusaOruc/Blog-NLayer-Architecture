using BusinessLayer.Concrate;
using DataAccessLayer.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NLayerBlogProje.Controllers
{
    public class AboutController : Controller
    {
        // GET: Abaut
        AboutManeger aboutManeger = new AboutManeger(new EFAboutDal());
        public PartialViewResult AboutIndex()
        {
            var values = aboutManeger.ListBL();
            return PartialView(values);
        }
    }
}