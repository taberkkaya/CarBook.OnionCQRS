using CarBook.Application.Features.Mediator.Results.AuthorResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.AuthorQueries
{
    public class GetAuthorByIdWithBlogsQuery : IRequest<GetAuthorByIdWithBlogsQueryResult>
    {
        public int Id { get; set; }

        public GetAuthorByIdWithBlogsQuery(int id)
        {
            Id = id;
        }
    }
}
