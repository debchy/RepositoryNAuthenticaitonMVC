namespace RepositoryNAuthenticaiton.Migrations.ApplicaitonDBContext
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using RepositoryNAuthenticaiton.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<RepositoryNAuthenticaiton.DAL.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ApplicaitonDBContext";
        }

        protected override void Seed(RepositoryNAuthenticaiton.DAL.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            if (!context.Users.Any(u => u.UserName == "connectdebu@gmail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "connectdebu@gmail.com", FirstName = "Debashis", LastName = "Chowdhury", Email = "connectdebu@gmail.com", EmailConfirmed = true, DateOfCreation=DateTime.Now };

                manager.Create(user, "123456");
            }

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
        }
    }
}
