using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers;

public class GetBlogQueryHandler : IRequestHandler<GetBlogQuery, List<GetBlogQueryResult>>
{
    private readonly IRepository<Blog> _repository;

    public GetBlogQueryHandler(IRepository<Blog> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetBlogQueryResult>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetAllAsync();
        return value!.Select(x => new GetBlogQueryResult
        {
            Id = x.Id,
            CoverImgUrl = x.CoverImgUrl,
            CreatedDate = x.CreatedDate,
            Title = x.Title,
            CategoryId = x.CategoryId,
            AuthorId = x.AuthorId,
        }).ToList();

    }
}
