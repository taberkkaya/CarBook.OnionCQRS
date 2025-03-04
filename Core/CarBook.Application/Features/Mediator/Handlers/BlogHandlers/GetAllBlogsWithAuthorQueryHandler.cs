using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.BlogInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers;

public class GetAllBlogsWithAuthorQueryHandler : IRequestHandler<GetAllBlogsWithAuthorQuery, List<GetAllBlogsWithAuthorQueryResult>>
{
    private readonly IBlogRepository _repository;

    public GetAllBlogsWithAuthorQueryHandler(IBlogRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<GetAllBlogsWithAuthorQueryResult>> Handle(GetAllBlogsWithAuthorQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllBlogsWithAuthor();
        return values.Select(x => new GetAllBlogsWithAuthorQueryResult
        {
            Id = x.Id,
            AuthorId = x.AuthorId,
            CategoryId = x.CategoryId,
            CoverImgUrl = x.CoverImgUrl,
            Title = x.Title,
            AuthorName = x.Author.Name,
            CategoryName = x.Category.Name,
            Description = x.Description,
            CreatedDate = x.CreatedDate,
        }).ToList();
    }
}
