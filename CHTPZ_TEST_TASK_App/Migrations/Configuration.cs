namespace CHTPZ_TEST_TASK_App.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CHTPZ_TEST_TASK_App.EF.chtpzDBcontext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "CHTPZ_TEST_TASK_App.EF.chtpzDBcontext";
        }

        protected override void Seed(CHTPZ_TEST_TASK_App.EF.chtpzDBcontext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
