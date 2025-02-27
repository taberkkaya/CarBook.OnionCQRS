using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers;

public class GetBlogByIdWithAuthorQueryHandler : IRequestHandler<GetBlogByIdWithAuthorQuery, GetBlogByIdWithAuthorQueryResult>
{
    private readonly IRepository<Blog> _repository;

    public GetBlogByIdWithAuthorQueryHandler(IRepository<Blog> repository)
    {
        _repository = repository;
    }

    public async Task<GetBlogByIdWithAuthorQueryResult> Handle(GetBlogByIdWithAuthorQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetAsync(x => x.Id == request.Id, x => x.Author);
        return new GetBlogByIdWithAuthorQueryResult
        {
            Id = value.Id,
            Author = value.Author,
            AuthorId = value.AuthorId,
            CategoryId = value.CategoryId,
            CoverImgUrl = value.CoverImgUrl,
            CreatedDate = value.CreatedDate,
            Title = value.Title,
        };
    }
}
