using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stavel2.Models;

namespace stavel2.Areas.Admin.Models
{
    public class MaterialEditViewModel : Material
    {
        private StavelDataContext ctx;

        public MaterialEditViewModel()
        {
            ctx = new StavelDataContext();
        }

        public MaterialEditViewModel(Material material)
        {
            ctx = new StavelDataContext();
            if (material==null)
                throw new NullReferenceException();
            Content = material.Content;
            Description = material.Description;
            Keywords = material.Keywords;
            SeoUrl = material.SeoUrl;
            Tag = material.Tag;
            Title = material.Title;
        }

        public List<SelectListItem> Categories()
        {
            return ctx.NavigationElements.Select(n => new SelectListItem { Text = n.Text, Value = n.Text }).ToList();
        }
    }
}