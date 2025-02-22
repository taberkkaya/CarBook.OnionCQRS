using CarBook.Application.Features.CQRS.Queries.CategoryQueries;
using CarBook.Application.Features.CQRS.Results.CategoryResult;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.CategoryHandlers;

public class GetCategoryByIdQueryHandler
{
    private readonly IRepository<Category> _repository;

    public GetCategoryByIdQueryHandler(IRepository<Category> repository)
    {
        _repository = repository;
    }

    public async Task<GetCategoryQueryResult> Handle(GetCategoryByIdQuery query)
    {
        var value = await _repository.GetByIdAsync(query.Id);
        return new GetCategoryQueryResult
        {
            Id = value!.Id,
            Name = value.Name
        };
    }
}
