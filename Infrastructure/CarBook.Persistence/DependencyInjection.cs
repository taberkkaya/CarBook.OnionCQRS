using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.CarInterfaces;
using CarBook.Persistence.Context;
using CarBook.Persistence.Repositories;
using CarBook.Persistence.Repositories.CarRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace CarBook.Persistence;
public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        services.AddScoped<CarBookContext>();
        services.AddScoped<ICarRepository, CarRepository>();
        services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
        return services;
    }
}
