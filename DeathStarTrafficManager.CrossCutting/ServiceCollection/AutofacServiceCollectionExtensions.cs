using Autofac;
using DeathStarTrafficManager.CrossCutting.Modules;

namespace DeathStarTrafficManager.CrossCutting.ServiceCollection;

public static class AutofacServiceCollectionExtensions
{
    public static void ConfigureModules(this ContainerBuilder builder)
    {
        builder.RegisterModule(new ApplicationModule());
    }
}