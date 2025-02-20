namespace CarBook.Domain.Entities;

public class SocialMedia : BaseEntity
{
    public string Name { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
}