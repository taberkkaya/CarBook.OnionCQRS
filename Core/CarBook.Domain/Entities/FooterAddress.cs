namespace CarBook.Domain.Entities;

public class FooterAddress : BaseEntity
{
    public string Description { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
}
