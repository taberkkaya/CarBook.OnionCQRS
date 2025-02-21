using CarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using CarBook.Application.Features.CQRS.Handlers.BannerHandlers;
using CarBook.Application.Features.CQRS.Handlers.BrandHandlers;
using CarBook.Application.Features.CQRS.Handlers.CarHandlers;
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

        services.AddScoped<CreateBrandCommandHandler>();
        services.AddScoped<GetBrandByIdQueryHandler>();
        services.AddScoped<GetBrandQueryHandler>();
        services.AddScoped<RemoveBrandCommandHandler>();
        services.AddScoped<UpdateBrandCommandHandler>();

        services.AddScoped<CreateCarCommandHandler>();
        services.AddScoped<GetCarByIdQueryHandler>();
        services.AddScoped<GetCarQueryHandler>();
        services.AddScoped<RemoveCarCommandHandler>();
        services.AddScoped<UpdateCarCommandHandler>();

        return services;
    }
}
