namespace CarBook.Dto.BlogDtos;

public class ResultAllBlogWithAuthorDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int AuthorId { get; set; }
    public string AuthorName { get; set; }

    public string CoverImgUrl { get; set; }
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }
}
