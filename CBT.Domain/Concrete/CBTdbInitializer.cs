using System.Data.Entity;
using System.Diagnostics;

namespace CBT.Domain.Concrete
{
    public class CBTDbInitializer : CreateDatabaseIfNotExists<CBTDbContext>
    {
        protected override void Seed(CBTDbContext context)
        {
            context.Database.Log = s => Debug.WriteLine(s);
            base.Seed(context);
        }
    }
}