using BusinessLayer.Concrate;
using BusinessLayer2.ValidationRules;
using DataAccessLayer.Concrate.EntityFramework;
using EntityLayer.Concrate.EntityFramework;
using FluentValidation.Results;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace NLayerBlogProje.Controllers.AdminPanel
{
    [Authorize]
    public class AdminAboutController : Controller
    {
        // GET: AdminAbout
        AboutManeger aboutManeger = new AboutManeger(new EFAboutDal());
        public ActionResult AdminAbout()
        {
            var values = aboutManeger.ListBL();
            return View(values);
        }
        [HttpGet]
        public ActionResult EditAbout(int id)
        {
            var values = aboutManeger.GetBL(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult EditAbout(About about)
        {
            AboutValidatior validationRules = new AboutValidatior();
            ValidationResult result = validationRules.Validate(about);

            //string dosyaAdi = Path.GetFileName(Request.Files[0].FileName);
            //if (dosyaAdi != "")
            //{ }

                //string uzanti = Path.GetExtension(Request.Files[0].FileName);
                //string link = "/Image/" + dosyaAdi;
                //Request.Files[0].SaveAs(Server.MapPath(link));
                //about.Img = link;

                string dosyaAdi = Path.GetFileName(Request.Files[0].FileName);
                string uzanti = Path.GetExtension(Request.Files[0].FileName);
                string link = "/Image/Portfolio/" + dosyaAdi;
                Request.Files[0].SaveAs(Server.MapPath(link));
                about.Img = link;

                //aboutManeger.UpdateBL(about);
            
            if (result.IsValid)
            {


                aboutManeger.UpdateBL(about);
                return RedirectToAction("AdminAbout");
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