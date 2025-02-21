using CarBook.Application.Features.CQRS.Queries.CarQueries;
using CarBook.Application.Features.CQRS.Results.CarResult;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers;

public class GetCarByIdQueryHandler
{
    private readonly IRepository<Car> _repository;

    public GetCarByIdQueryHandler(IRepository<Car> repository)
    {
        _repository = repository;
    }

    public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
    {
        var value = await _repository.GetByIdAsync(query.Id);
        return new GetCarByIdQueryResult
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
        };
    }
}
