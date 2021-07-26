using System.Data.Entity.Migrations;

namespace RepositoryPattern.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<RepositoryPatternContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RepositoryPatternContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
