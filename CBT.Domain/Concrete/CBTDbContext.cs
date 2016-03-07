using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBT.Domain.Concrete
{
    public class CBTDbContext : IdentityDbContext<IdentityUser>
    {
        public CBTDbContext() : base("CBTDatabase") { }

        static CBTDbContext()
        {
            Database.SetInitializer(new CBTDbInitializer());
        }
    }
}
