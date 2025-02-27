using CarBook.Application.Features.Mediator.Queries.AuthorQueries;
using CarBook.Application.Features.Mediator.Results.AuthorResults;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.AuthorInterfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.AuthorHandlers;

public class GetAuthorByIdWithBlogsQueryHandler : IRequestHandler<GetAuthorByIdWithBlogsQuery, GetAuthorByIdWithBlogsQueryResult>
{
    private readonly IAuthorRepository _repository;

    public GetAuthorByIdWithBlogsQueryHandler(IAuthorRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetAuthorByIdWithBlogsQueryResult> Handle(GetAuthorByIdWithBlogsQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetAuthorByIdWithBlogs(request.Id);
        return new GetAuthorByIdWithBlogsQueryResult
        {
            Id = value.Id,
            Blogs = value.Blogs,
            Description = value.Description,
            ImageUrl = value.ImageUrl,
            Name = value.Name   
        };
    }
}
