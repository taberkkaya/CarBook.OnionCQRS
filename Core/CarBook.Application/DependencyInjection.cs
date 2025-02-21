using CarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using CarBook.Application.Features.CQRS.Handlers.BannerHandlers;
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

        services.AddScoped<CreateBannerCommandHandler>();
        services.AddScoped<GetBannerByIdQueryHandler>();
        services.AddScoped<GetBannerQueryHandler>();
        services.AddScoped<RemoveBannerCommandHandler>();
        services.AddScoped<UpdateBannerCommandHandler>();

        return services;
    }
}
