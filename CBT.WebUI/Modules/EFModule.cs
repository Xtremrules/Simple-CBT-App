using Autofac;
using CBT.Domain.Concrete;

namespace CBT.WebUI.Modules
{
    public class EFModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(CBTDbContext)).AsSelf();
        }
    }
}