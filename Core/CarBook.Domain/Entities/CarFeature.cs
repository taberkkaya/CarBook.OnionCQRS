namespace CarBook.Domain.Entities;

public class CarFeature : BaseEntity
{
    public int CarId { get; set; }
    public Car Car { get; set; }
    public int FeatureId { get; set; }
    public Feature Feature { get; set; }
    public bool Avaliable { get; set; }
}