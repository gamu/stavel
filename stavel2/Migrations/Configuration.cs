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
            context.NavigationElements.AddOrUpdate(n=>n.Text,
                new NavigationElement{Text="Главная",Tag="Top"},
                new NavigationElement { Text = "Проект электрики", Tag = "Top", Url = "/project-electriki" },
                new NavigationElement { Text = "Электромонтаж", Tag = "Top" },
                new NavigationElement { Text = "Вакансии", Tag = "Top" },
                new NavigationElement { Text = "Контакты", Tag = "Top" });

            context.NavigationTypes.AddOrUpdate(n=>n.Value,
                new NavigationType{Value = "Top"},
                new NavigationType { Value = "project-electriki" });

            context.SaveChanges();
        }
    }
}
