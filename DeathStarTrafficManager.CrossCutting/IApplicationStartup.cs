using Autofac;
using Microsoft.Extensions.DependencyInjection;

namespace DeathStarTrafficManager.CrossCutting;

public interface IApplicationStartup
{
    void ConfigureServices(IServiceCollection services);
    void ConfigureContainer(ContainerBuilder builder);
}