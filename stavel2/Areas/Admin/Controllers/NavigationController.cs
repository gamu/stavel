using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stavel2.Models;

namespace stavel2.Areas.Admin.Controllers
{
    public class NavigationController : Controller
    {
        //
        // GET: /Admin/Navigation/
        StavelDataContext ctx = new StavelDataContext();
        
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetElements()
        {
            var elements = ctx.NavigationElements.ToList();
            return Json(elements,JsonRequestBehavior.AllowGet);
        }

        public ActionResult CreateElement()
        {
            var element = ctx.NavigationElements.Create();
            return View(element);
        }

        [HttpPost]
        public ActionResult CreateElement(NavigationElement element)
        {
            ctx.NavigationElements.Add(element);
            ctx.SaveChanges();
            return Index();
        }

        public ActionResult Edit(int Id)
        {
            var element=ctx.NavigationElements.SingleOrDefault(n => n.Id == Id);
            return View(element);
        }

        [HttpPost]
        public ActionResult Edit(NavigationElement material)
        {
            var element = ctx.NavigationElements.SingleOrDefault(n => n.Id == material.Id);
            element.Text = material.Text;
            element.Url = material.Url;
            element.Tag = material.Tag;
            ctx.SaveChanges();
            return Index();
        }

        public JsonResult ListByTag(string Id)
        {
            var elements = ctx.NavigationElements.Where(n => n.Tag == Id).ToList();
            return Json(elements, JsonRequestBehavior.AllowGet);
        }

    }
}
