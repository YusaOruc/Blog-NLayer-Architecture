using BusinessLayer.Concrate;
using DataAccessLayer.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NLayerBlogProje.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        MyPortfolioManeger my = new MyPortfolioManeger(new EFMyPortfolioDal());
        public PartialViewResult PortfolioIndex()
        {
            var values = my.ListBL();
            return PartialView(values);
        }
    }
}