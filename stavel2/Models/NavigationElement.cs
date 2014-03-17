using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace stavel2.Models
{
    public class NavigationElement
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
        public string Tag { get; set; }
        public int? Parent { get; set; }
    }
}