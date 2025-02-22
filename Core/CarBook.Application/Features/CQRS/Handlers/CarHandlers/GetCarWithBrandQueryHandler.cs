using CarBook.Application.Features.CQRS.Results.CarResult;
using CarBook.Application.Interfaces.CarInterfaces;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers;

public class GetCarWithBrandQueryHandler
{
    private readonly ICarRepository _repository;

    public GetCarWithBrandQueryHandler(ICarRepository carRepository)
    {
        _repository = carRepository;
    }

    public List<GetCarWithBrandQueryResult> Handle()
    {
        var values = _repository.GetCarsListWithBrand();
        return values!.Select(x => new GetCarWithBrandQueryResult
        {
            Id = x!.Id,
            BrandId = x.BrandId,
            BrandName = x.Brand.Name,
            Model = x.Model,
            CoverImageUrl = x.CoverImageUrl,
            Km = x.Km,
            Transmission = x.Transmission,
            Seat = x.Seat,
            Luggage = x.Luggage,
            Fuel = x.Fuel,
            BigImageUrl = x.BigImageUrl
        }).ToList();
    }
}
