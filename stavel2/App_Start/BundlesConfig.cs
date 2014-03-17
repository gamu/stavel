using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace stavel2
{
    public class BundlesConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Script/scripts")
                .Include("~/Content/Scripts/js/jquery.js")
                .Include("~/Content/Scripts/js/superfish.js")
                .Include("~/Content/Scripts/js/jquery.mobilemenu.js")
                .Include("~/Content/Scripts/js/jquery.flexslider.js")
                .Include("~/Content/Scripts/js/jquery.easing.1.3.js")
                .Include("~/Content/Scripts/js/script.js"));

            bundles.Add(new StyleBundle("~/Styles/style")
                .Include("~/Content/style.css"));

        }

    }
}