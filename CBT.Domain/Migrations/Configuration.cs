namespace CBT.Domain.Migrations
{
    using Identity;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Concrete.CBTDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Concrete.CBTDbContext context)
        {
            AppRoleManager roleMgr = new AppRoleManager(new RoleStore<IdentityRole>(context));
            AppUserManager userMgr = new AppUserManager(new UserStore<IdentityUser>(context));

            if (!roleMgr.RoleExists("Admin"))
                roleMgr.Create(new IdentityRole("Admin"));

            var AdminUser = userMgr.FindByName("AdminUser");
            if (AdminUser == null)
            {
                userMgr.Create(new IdentityUser
                {
                    UserName = "AdminUser",
                    Email = "admin@cbt.com",
                }, "AdminSecret");
                AdminUser = userMgr.FindByName("AdminUser");
            }

            if (!userMgr.IsInRole(AdminUser.Id, "AdminUser"))
                userMgr.AddToRole(AdminUser.Id, "AdminUser");
        }
    }
}
