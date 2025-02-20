using CarBook.Application.Features.CQRS.Queries.AboutQueries;
using CarBook.Application.Features.CQRS.Results.AboutResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandlers;

public class GetAboutByIdQueryHandler
{
    private readonly IRepository<About> _aboutRepository;

    public GetAboutByIdQueryHandler(IRepository<About> aboutRepository)
    {
        _aboutRepository = aboutRepository;
    }

    public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery query)
    {
        var value = await _aboutRepository.GetByIdAsync(query.Id);
        return new GetAboutByIdQueryResult
        {
            Id = value!.Id,
            Title = value.Title,
            Description = value.Description,
            ImageUrl = value.ImageUrl
        };

    }
}
