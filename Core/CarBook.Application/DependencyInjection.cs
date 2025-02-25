using CarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using CarBook.Application.Features.CQRS.Handlers.BannerHandlers;
using CarBook.Application.Features.CQRS.Handlers.BrandHandlers;
using CarBook.Application.Features.CQRS.Handlers.CarHandlers;
using CarBook.Application.Features.CQRS.Handlers.CategoryHandlers;
using CarBook.Application.Features.CQRS.Handlers.ContactHandlers;
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
        services.AddScoped<GetCarWithBrandQueryHandler>();
        services.AddScoped<GetLast5CarsWithBrandQueryHandler>();

        services.AddScoped<CreateCategoryCommandHandler>();
        services.AddScoped<GetCategoryByIdQueryHandler>();
        services.AddScoped<GetCategoryQueryHandler>();
        services.AddScoped<RemoveCategoryCommandHandler>();
        services.AddScoped<UpdateCategoryCommandHandler>();

        services.AddScoped<CreateContactCommandHandler>();
        services.AddScoped<GetContactByIdQueryHandler>();
        services.AddScoped<GetContactQueryHandler>();
        services.AddScoped<RemoveContactCommandHandler>();
        services.AddScoped<UpdateContactCommandHandler>();

        return services;
    }
}
