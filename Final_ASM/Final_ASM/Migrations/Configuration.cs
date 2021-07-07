namespace Final_ASM.Migrations
{
    using Final_ASM.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Final_ASM.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Final_ASM.Models.ApplicationDbContext context)
        {
            if (!context.Users.Any())
            {
                CreateUser(context, "admin@fpt.edu.vn", "admin");
                CreateUser(context, "staff@fpt.edu.vn", "staff");
                CreateUser(context, "trainer@fpt.edu.vn", "trainer");
                CreateUser(context, "trainee@fpt.edu.vn", "trainee");

                CreateRole(context, "Admin");
                CreateRole(context, "Staff");
                CreateRole(context, "Trainer");
                CreateRole(context, "Trainee");


                AddUserToRole(context, "admin@fpt.edu.vn", "Admin");
                AddUserToRole(context, "staff@fpt.edu.vn", "Staff");
                AddUserToRole(context, "trainer@fpt.edu.vn", "Trainer");
                AddUserToRole(context, "trainee@fpt.edu.vn", "Trainee");
                AddUserToRole(context, "duongpt4@fe.edu.vn", "Trainer");

            }
        }

        private void CreateUser(ApplicationDbContext context, string email, string password)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            userManager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 1,
                RequireNonLetterOrDigit = false,
                RequireDigit = false,
                RequireLowercase = false,
                RequireUppercase = false,

            };

            var user = new ApplicationUser  
            {
                UserName = email,
                Email = email,

            };

            var userCreateResult = userManager.Create(user, password);

            if (!userCreateResult.Succeeded)
            {
                throw new Exception(string.Join("; ", userCreateResult.Errors));
            }
        }

        private void CreateRole(ApplicationDbContext context, string roleName)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var roleCreateResult = roleManager.Create(new IdentityRole(roleName));
            if (!roleCreateResult.Succeeded)
            {
                throw new Exception(string.Join("; ", roleCreateResult.Errors));
            }
        }

        private void AddUserToRole(ApplicationDbContext context, string userName, string roleName)
        {
            var user = context.Users.First(u => u.UserName == userName);
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var addAdminRoleResult = userManager.AddToRole(user.Id, roleName);
            if (!addAdminRoleResult.Succeeded)
            {
                throw new Exception(string.Join("; ", addAdminRoleResult.Errors));
            }
        }
    }
}
