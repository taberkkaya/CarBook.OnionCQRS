using CarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using CarBook.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CarBook.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<CreateAboutCommandHandler>();
        services.AddScoped<GetAboutByIdQueryHandler>();
        services.AddScoped<GetAboutQueryHandler>();
        services.AddScoped<RemoveAboutCommandHandler>();
        services.AddScoped<UpdateAboutCommandHandler>();

        return services;
    }
}
