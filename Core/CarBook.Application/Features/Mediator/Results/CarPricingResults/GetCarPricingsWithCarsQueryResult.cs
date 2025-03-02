namespace CarBook.Application.Features.Mediator.Results.CarPricingResults
{
    public class GetCarPricingsWithCarsQueryResult
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Amount { get; set; }
        public string ImageUrl { get; set; }
    }
}
