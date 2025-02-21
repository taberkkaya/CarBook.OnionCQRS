using CarBook.Application.Features.CQRS.Results.CarResult;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers;

public class GetCarQueryHandler
{
    private readonly IRepository<Car> _repository;

    public GetCarQueryHandler(IRepository<Car> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetCarQueryResult>> Handle()
    {
        var values = await _repository.GetAllAsync();
        return values!.Select(x => new GetCarQueryResult
        {
            Id = x!.Id,
            BrandId = x.BrandId,
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
