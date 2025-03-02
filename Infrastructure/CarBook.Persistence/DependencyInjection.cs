using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.AuthorInterfaces;
using CarBook.Application.Interfaces.BlogInterfaces;
using CarBook.Application.Interfaces.CarInterfaces;
using CarBook.Application.Interfaces.CarPricingInterfaces;
using CarBook.Persistence.Context;
using CarBook.Persistence.Repositories;
using CarBook.Persistence.Repositories.AuthorRepositories;
using CarBook.Persistence.Repositories.BlogRepositories;
using CarBook.Persistence.Repositories.CarPricingRepositories;
using CarBook.Persistence.Repositories.CarRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace CarBook.Persistence;
public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        services.AddScoped<CarBookContext>();
        services.AddScoped<ICarRepository, CarRepository>();
        services.AddScoped<IAuthorRepository, AuthorRepository>();
        services.AddScoped<IBlogRepository, BlogRepository>();
        services.AddScoped<ICarPricingRepository, CarPricingRepository>();
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        return services;
    }
}
