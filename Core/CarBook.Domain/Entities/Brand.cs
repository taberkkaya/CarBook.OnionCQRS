namespace CarBook.Domain.Entities;

public class Brand: EntityBase
{
    public string Name { get; set; }
    public List<Car> Cars { get; set; }
}
