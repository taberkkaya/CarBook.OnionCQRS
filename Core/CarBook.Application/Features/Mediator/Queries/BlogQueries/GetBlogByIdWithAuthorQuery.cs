using CarBook.Application.Features.Mediator.Results.BlogResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.BlogQueries;

public class GetBlogByIdWithAuthorQuery : IRequest<GetBlogByIdWithAuthorQueryResult>
{
    public int Id { get; set; }

    public GetBlogByIdWithAuthorQuery(int id)
    {
        Id = id;
    }
}
