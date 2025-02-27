using System.Text.Json.Serialization;

namespace CarBook.Domain.Entities;

public class Author : BaseEntity
{
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
    [JsonIgnore]
    public List<Blog>? Blogs { get; set; }
}
