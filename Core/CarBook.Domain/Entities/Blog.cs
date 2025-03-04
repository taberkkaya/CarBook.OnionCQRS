using System.Text.Json.Serialization;

namespace CarBook.Domain.Entities;

public class Blog : BaseEntity
{
    public string Title { get; set; }
    public int AuthorId { get; set; }
    [JsonIgnore]
    public Author Author { get; set; }
    public string CoverImgUrl { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public string Description { get; set; }
}
