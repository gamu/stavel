using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace stavel2.App_Code
{
    public static class HelperExtensions
    {
        public static MvcHtmlString GetProjectMini(this HtmlHelper helper, string folder)
        {
            StringBuilder htmlOutput = new StringBuilder();
            htmlOutput.Append("<fieldset style=\"border: 1px solid #EABD16;padding-left:15%;background: url(../Content/Images/proj_logo.png) repeat-y\">");
            htmlOutput.Append("<ul>");
            string[] filePaths = Directory.GetFiles(helper.ViewContext.HttpContext.Server.MapPath("~/Content/images/ProjectsPhoto"));
            for (int i = 0; i < 2; i++)
            {
                var Url = new UrlHelper(helper.ViewContext.RequestContext);
                string imageFile = Regex.Match(filePaths[i], @"o\\([\S]{1,})\.(\S){1,}$").Value.Replace(@"o\", string.Empty);
                htmlOutput.Append("<li style=\"padding-top:7px;\">");
                //htmlOutput.AppendFormat("<a href={0}><img  width=\"150px\" height=\"150px\" src={1} /></a>", Url.Action("Projects", "Home"), Url.Content("~/images/ProjectsPhoto/" + imageFile));
                htmlOutput.Append("</li>");
            }
            htmlOutput.Append("<li style=\"padding-top:7px;\">");
            htmlOutput.Append("</li>");
            htmlOutput.Append("</ul>");
            htmlOutput.Append("</fieldset>");
            MvcHtmlString helperString = new MvcHtmlString(htmlOutput.ToString());
            return helperString;
        }

        public static MvcHtmlString Script(this HtmlHelper helper, string scriptUri)
        {
            string scriptString =
                   string.Format(@"<script src={0} type=""text/javascript""></script>", scriptUri);
            MvcHtmlString helperString = new MvcHtmlString(scriptString);
            return helperString;
        }
    }
}