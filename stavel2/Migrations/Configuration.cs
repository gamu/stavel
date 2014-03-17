using stavel2.Models;

namespace stavel2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<stavel2.Models.StavelDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "gamu_30";
        }

        protected override void Seed(stavel2.Models.StavelDataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.NavigationElements.AddOrUpdate(n=>n.Text,
                new NavigationElement{Text="Главная"},
                new NavigationElement{Text="Электропроект"},
                new NavigationElement { Text = "Электромонтаж" },
                new NavigationElement{Text="Вакансии"},
                new NavigationElement{Text="Контакты"});
            context.SaveChanges();
        }
    }
}
