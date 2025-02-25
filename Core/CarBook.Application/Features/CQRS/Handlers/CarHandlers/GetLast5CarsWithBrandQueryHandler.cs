using CarBook.Application.Features.CQRS.Queries.CarQueries;
using CarBook.Application.Features.CQRS.Results.CarResult;
using CarBook.Application.Interfaces.CarInterfaces;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers;

public class GetLast5CarsWithBrandQueryHandler
{
    private readonly ICarRepository _repository;

    public GetLast5CarsWithBrandQueryHandler(ICarRepository repository)
    {
        _repository = repository;
    }

    public List<GetLast5CarsWithBrandQueryResult> Handle()
    {
        var values = _repository.GetLast5CarsListWithBrand();
        return values.Select(value => new GetLast5CarsWithBrandQueryResult
        {
            Id = value!.Id,
            BrandId = value.BrandId,
            Model = value.Model,
            CoverImageUrl = value.CoverImageUrl,
            Km = value.Km,
            Transmission = value.Transmission,
            Seat = value.Seat,
            Luggage = value.Luggage,
            Fuel = value.Fuel,
            BigImageUrl = value.BigImageUrl
        }).ToList();
    }
}
