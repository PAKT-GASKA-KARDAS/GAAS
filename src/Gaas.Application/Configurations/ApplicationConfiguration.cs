using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Gaas.Application.Configurations;
public static class ApplicationConfigurations
{
    public static IServiceCollection GetApplicationConfigurations(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        return services;
    }
}