namespace CarBook.Domain.Entities;

public class CarDescription : BaseEntity
{
    public string Details { get; set; }
    public int CarId { get; set; }
    public Car Car { get; set; }
}
