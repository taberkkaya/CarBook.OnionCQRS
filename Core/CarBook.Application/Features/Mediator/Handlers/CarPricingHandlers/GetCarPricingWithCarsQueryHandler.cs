using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using CarBook.Application.Features.Mediator.Results.CarPricingResults;
using CarBook.Application.Interfaces.CarPricingInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.CarPricingHandlers;

public class GetCarPricingWithCarsQueryHandler : IRequestHandler<GetCarPricingWithCarsQuery, List<GetCarPricingsWithCarsQueryResult>>
{
    private readonly ICarPricingRepository _repository;

    public GetCarPricingWithCarsQueryHandler(ICarPricingRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<GetCarPricingsWithCarsQueryResult>> Handle(GetCarPricingWithCarsQuery request, CancellationToken cancellationToken)
    {
        var values =  _repository.GetPricingsWithCars();
        return values.Select(x => new GetCarPricingsWithCarsQueryResult
        {
            Id = x.Id,
            Amount = x.Price,
            Brand = x.Car.Brand.Name,
            ImageUrl = x.Car.BigImageUrl,
            Model = x.Car.Model,
        }).ToList();
    }
}
