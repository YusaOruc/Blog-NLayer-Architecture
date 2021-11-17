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

namespace NLayerBlogProje.Controllers.AdminPanel
{
    [Authorize]
    public class AdminSkillController : Controller
    {
        // GET: AdminSkill
        SkillManeger skillManeger = new SkillManeger(new EFSkillDal());
        SkillsValidator validationRules = new SkillsValidator();
        
        public ActionResult AdminSkill(int p=1)
        {
            var values = skillManeger.ListBL().ToPagedList(p, 5);
            return View(values);
        }
        [HttpGet]
        public ActionResult AddSkills()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSkills(Skill skill)
        {

            ValidationResult result = validationRules.Validate(skill);
            if (result.IsValid)
            {
                skillManeger.InsertBL(skill);
                return RedirectToAction("AdminSkill");
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
        public ActionResult DeleteSkill(int id)
        {
            var value = skillManeger.GetBL(id);
            skillManeger.DeleteBL(value);
            return RedirectToAction("AdminSkill");
        }
        [HttpGet]
        public ActionResult EditSkill(int id)
        {
            var values = skillManeger.GetBL(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult EditSkill(Skill skill)
        {
            
            ValidationResult result = validationRules.Validate(skill);

            if (result.IsValid)
            {
                skillManeger.UpdateBL(skill);
                return RedirectToAction("AdminSkill");
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