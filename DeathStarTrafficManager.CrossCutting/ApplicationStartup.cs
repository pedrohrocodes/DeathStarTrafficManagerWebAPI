using Autofac;
using Microsoft.Extensions.DependencyInjection;

namespace DeathStarTrafficManager.CrossCutting;

public class ApplicationStartup : IApplicationStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        throw new NotImplementedException();
    }

    public void ConfigureContainer(ContainerBuilder builder)
    {
        throw new NotImplementedException();
    }
}