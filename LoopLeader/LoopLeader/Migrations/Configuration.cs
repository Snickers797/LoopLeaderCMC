
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using LoopLeader.Models;

namespace LoopLeader.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            this.AddUserAndRoles();
        }

        bool AddUserAndRoles()
        {
            bool success = false;
            var idManager = new IdentityManager();
            success = idManager.CreateRole("Admin");
            if (!success == true) return success;

            success = idManager.CreateRole("CanEdit");
            if (!success == true) return success;

            success = idManager.CreateRole("User");
            if (!success) return success;

            var newUser = new ApplicationUser()
            {
                UserName = "SMcDonald",
                FirstName = "Skip",
                LastName = "McDonald",
                EmailAddress = "contacteyemac@gmail.com",
                ZipCode = "00000",
                Country = "USA"
            };

            success = idManager.CreateUser(newUser, "!2OL4Admin!");
            if(!success) return success;

            success = idManager.AddUserToRole(newUser.Id, "Admin");
            if (!success) return success;

            success = idManager.AddUserToRole(newUser.Id, "CanEdit");
            if (!success) return success;

            success = idManager.AddUserToRole(newUser.Id, "User");
            if (!success) return success;

            return success;
        }
    }
}
