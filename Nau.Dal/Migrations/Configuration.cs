namespace Nau.Dal.Migrations
{
    using Nau.Dal.SeedConfiguration;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Nau.Dal.NauDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Nau.Dal.NauDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            new ActivityTypeSeed(context);
            new CategorySeed(context);
            new MealTypeSeed(context);
            new AdminSeed(context);
            new FoodSeed(context);
        }
    }
}
