using CarBook.Application.Features.Mediator.Results.CarPricingResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.CarPricingQueries;

public class GetCarPricingWithCarsQuery : IRequest<List<GetCarPricingsWithCarsQueryResult>>
{

}
