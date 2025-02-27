using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.BlogCommands;

public class CreateBlogCommand : IRequest
{
    public string Title { get; set; }
    public int AuthorId { get; set; }
    public string CoverImgUrl { get; set; }
    public int CategoryId { get; set; }
}
