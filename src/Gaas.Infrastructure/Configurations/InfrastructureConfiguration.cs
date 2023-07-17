using Gaas.Application.Interfaces;
using Gaas.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace Gaas.Infrastructure.Configurations;
public static class InfrastructureConfiguration
{
    public static IServiceCollection GetInfrastructureConfiguration(this IServiceCollection services)
    {
        services
            .AddScoped<IVisitRepository, VisitRepository>()
            .AddScoped<IClientRepository, ClientRepository>()
            .AddMongoDb();

        return services;
    }

    private static IServiceCollection AddMongoDb(this IServiceCollection services)
    {
        services
            .AddSingleton<IMongoClient>(sp => new MongoClient("mongodb://localhost"))
            .AddSingleton<IMongoDatabase>(sp =>
            {
                var client = sp.GetService<IMongoClient>();
                return client!.GetDatabase("gaas");
            });

        return services;
    }
}
