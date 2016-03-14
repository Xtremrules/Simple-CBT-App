using CBT.Domain.Abstracts;
using CBT.Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading;
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

        public DbSet<Batch> Batches { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<SQuestion> SQuestions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<SQuestion>().HasMany(x => x.Batches)
                .WithMany(x => x.SQuestions)
                .Map(x => x.MapLeftKey("SquestionID").MapRightKey("BatchID")
                .ToTable("SQuestionBatch"));

            modelBuilder.Entity<IdentityUser>().ToTable("Users").Property(x => x.Id).HasColumnName("UserId");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserRoles");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogins");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaims").Property(x => x.Id).HasColumnName("UserClaimId");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles").Property(x => x.Id).HasColumnName("RoleName");
        }

        public static CBTDbContext Create() => new CBTDbContext();

        public override Task<int> SaveChangesAsync()
        {
            ImplementAuditableEntity();
            return base.SaveChangesAsync();
        }

        void ImplementAuditableEntity()
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(x => x.Entity is IAuditableEntity
                && (x.State == EntityState.Added || x.State == EntityState.Modified));
            foreach (var entry in modifiedEntries)
            {
                IAuditableEntity entity = entry.Entity as IAuditableEntity;
                if (entity != null)
                {
                    string identityName = Thread.CurrentPrincipal.Identity.Name;
                    DateTime now = DateTime.Now;
                    if (entry.State == EntityState.Added)
                    {
                        entity.CreatedBy = identityName;
                        entity.CreatedDate = now;
                    }
                    else
                    {
                        Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                        Entry(entity).Property(x => x.CreatedDate).IsModified = false;
                    }

                    entity.UpdatedBy = identityName;
                    entity.UpdatedDate = now;
                }
            }
        }
    }
}
