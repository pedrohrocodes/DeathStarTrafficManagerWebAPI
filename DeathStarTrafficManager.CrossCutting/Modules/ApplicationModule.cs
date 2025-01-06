using Autofac;
using DeathStarTrafficManager.Application.Services;
using DeathStarTrafficManager.Contracts.Services;

namespace DeathStarTrafficManager.CrossCutting.Modules;

public class ApplicationModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<ThirdPartyApiService>()
            .As<IThirdPartyApiService>()
            .InstancePerLifetimeScope();
    }
}