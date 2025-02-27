using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.BlogCommands;

public class UpdateBlogCommand : IRequest
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int AuthorId { get; set; }
    public string CoverImgUrl { get; set; }
    public int CategoryId { get; set; }
}
