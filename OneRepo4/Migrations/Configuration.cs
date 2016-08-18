using OneRepo.Controllers;

namespace OneRepo4.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OneRepo.Controllers.RepoItemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(OneRepo.Controllers.RepoItemContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.RepoItems.AddOrUpdate(
              p => p.Id,
              new RepoItem { Id = 1, Description = "Blablabla", Name = "Name1", Size = 123, TimeStamp = DateTime.Now, URL = "http://www.rv337.com/vimages/shared/vnews/stories/564dff6e7ad28/1_pie.jpg " },
              new RepoItem { Id = 2, Description = "Blablabla", Name = "Name2", Size = 123, TimeStamp = DateTime.Now, URL = "http://www.bettycrocker.com/-/media/Images/Betty-Crocker/Recipe-Browse/Dish/Pies/pie-recipes-featureB_080115.jpg" },
              new RepoItem { Id = 3, Description = "Blablabla", Name = "Name3", Size = 123, TimeStamp = DateTime.Now, URL = "http://www.bettycrocker.com/-/media/Images/Betty-Crocker/Recipe-Browse/Dish/Pies/pie-recipes-featureB_080115.jpg" }
            );
            
        }
    }
}
