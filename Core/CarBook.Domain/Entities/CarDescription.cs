namespace CarBook.Domain.Entities;

public class CarDescription : BaseEntity
{
    public string Details { get; set; }
    public int CarId { get; set; }
    public Car Car { get; set; }
}

public class Contact : BaseEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Message { get; set; }
    public DateTime SendDate { get; set; }
}