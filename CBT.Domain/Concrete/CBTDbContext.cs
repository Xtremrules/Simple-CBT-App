using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using CBT.Domain.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CBT.Domain.Concrete
{
    public class CBTDbContext : IdentityDbContext<IdentityUser>
    {
        public CBTDbContext() : base("CBTDatabase") { }

        static CBTDbContext()
        {
            Database.SetInitializer(new CBTDbInitializer());
        }

        public DbSet<Batch> Batches { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<SQuestion> SQuestions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


            modelBuilder.Entity<IdentityUser>().ToTable("Users").Property(x => x.Id).HasColumnName("UserId");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserRoles");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogins");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaims").Property(x => x.Id).HasColumnName("UserClaimId");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles").Property(x => x.Id).HasColumnName("RoleName");
        }
    }
}
