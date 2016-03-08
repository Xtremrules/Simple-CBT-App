using CBT.Domain.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Diagnostics;

namespace CBT.Domain.Concrete
{
    public class CBTDbInitializer : CreateDatabaseIfNotExists<CBTDbContext>
    {
        protected override void Seed(CBTDbContext context)
        {
            context.Database.Log = s => Debug.WriteLine(s);

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

            if (!roleMgr.RoleExists("AdminRole"))
            {
                roleMgr.Create(new IdentityRole("AdminRole"));
            }

            if (!userMgr.IsInRole(AdminUser.Id, "AdminRole"))
                userMgr.AddToRole(AdminUser.Id, "AdminRole");

            base.Seed(context);
        }
    }
}