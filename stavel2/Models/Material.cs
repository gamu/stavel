using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace stavel2.Models
{
    public class Material
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string SeoUrl { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }
    }
}