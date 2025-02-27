using CarBook.Domain.Entities;

namespace CarBook.Application.Features.Mediator.Results.BlogResults;

public class GetBlogQueryResult
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int AuthorId { get; set; }
    public string CoverImgUrl { get; set; }
    public int CategoryId { get; set; }
    public DateTime CreatedDate { get; set; }
}
