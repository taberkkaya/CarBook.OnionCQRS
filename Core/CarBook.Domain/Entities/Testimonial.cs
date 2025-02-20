namespace CarBook.Domain.Entities;

public class Testimonial : BaseEntity
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}

