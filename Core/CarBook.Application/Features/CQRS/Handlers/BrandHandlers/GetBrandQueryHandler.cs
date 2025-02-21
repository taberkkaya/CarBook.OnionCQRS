using CarBook.Application.Features.CQRS.Results.BrandResult;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.BrandHandlers;

public class GetBrandQueryHandler
{
    private readonly IRepository<Brand> _repository;

    public GetBrandQueryHandler(IRepository<Brand> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetBrandQueryResult>> Handle()
    {
        var values = await _repository.GetAllAsync();
        return values!.Select(x => new GetBrandQueryResult
        {
            Id = x.Id,
            Name = x.Name
        }).ToList();
    }
}
