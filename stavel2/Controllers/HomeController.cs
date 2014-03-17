using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stavel2.Models;

namespace stavel2.Controllers
{
    public class HomeController : Controller
    {
        StavelDataContext ctx = new StavelDataContext();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //string firsPage = Url.Content("~/"+"electromontazhnye_raboty-v-moskve");
            //return RedirectPermanent(firsPage);
            return View();
        }

        public ActionResult GetArticle(string id)
        {
            var article = ctx.Materials.FirstOrDefault(n => n.SeoUrl == id);
            if (article != null)
            {
                ViewBag.CurrentArticle = article;
                return View(article);
            }                
            return View();
        }
    }
}
