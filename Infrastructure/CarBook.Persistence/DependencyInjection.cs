using CarBook.Application.Interfaces;
using CarBook.Persistence.Context;
using CarBook.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CarBook.Persistence;
public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        services.AddScoped<CarBookContext>();
        services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
        return services;
    }
}
