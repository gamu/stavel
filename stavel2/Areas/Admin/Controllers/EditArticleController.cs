using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using stavel2.Areas.Admin.Models;
using stavel2.Models;

namespace stavel2.Areas.Admin.Controllers
{
    public class EditArticleController : Controller
    {
        //
        // GET: /Admin/EditArticle/
        StavelDataContext ctx = new StavelDataContext();
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var article = ctx.Materials.FirstOrDefault(n => n.Id == id);
            return View(article);
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(Material material)
        {
            ctx.Materials.AddOrUpdate(material);
            ctx.SaveChanges();
            return Edit(material.Id);
        }
        [HttpGet]
        public ActionResult Create()
        {
            var materialEntry = ctx.Materials.Create();
            return View(materialEntry);
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult Create(Material material)
        {
            ctx.Materials.AddOrUpdate(material);
            ctx.SaveChanges();
            return Create();
        }

        public ActionResult List()
        {            
            return View();
        }

        public ActionResult Delete(int Id)
        {
            var removedMaterial = ctx.Materials.SingleOrDefault(n => n.Id == Id);
            if (removedMaterial != null)
            {
                ctx.Materials.Remove(removedMaterial);
                ctx.SaveChanges();
            }                
            return List();
        }

        public JsonResult GetListJson()
        {
            var materialsDto = ctx.Materials.
                Select(n => new MaterialsListViewModel { Id = n.Id, Title = n.Title, SeoUrl = n.SeoUrl }).
                ToList();
            return Json(materialsDto, JsonRequestBehavior.AllowGet);
        }

    }
}
