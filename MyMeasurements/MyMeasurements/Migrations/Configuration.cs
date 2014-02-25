using System.Collections.Generic;
using MyMeasurements.Domain;

namespace MyMeasurements.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyMeasurements.Web.Infrastructure.DataRepositoryDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MyMeasurements.Web.Infrastructure.DataRepositoryDb context)
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
            context.User.AddOrUpdate(
                u=>u.Name,
                new User()
                    {
                        Id = 1,
                        Name = "Barry Smith",
                        Email = "barrysmithdev@test.com"
                      //  BrandMeasurements = new List<BrandMeasurement>(),
                       // ProfileMeasurement = new ProfileMeasurement(),
                       // PartnersProfileMeasurement = new ProfileMeasurement()
                    }
                );
        }
    }
}
