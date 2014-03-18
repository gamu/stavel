using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace stavel2.Models
{
    public class StavelDataContext:DbContext
    {
        public StavelDataContext() : base("gamu_30") { }        
        public DbSet<Material> Materials { get; set; }
        public DbSet<NavigationElement> NavigationElements { get; set; }
        public DbSet<NavigationType> NavigationTypes { get; set; }
    }
}