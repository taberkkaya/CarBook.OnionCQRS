using CarBook.Application.Interfaces.CarPricingInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories.CarPricingRepositories
{
    public class CarPricingRepository : ICarPricingRepository
    {
        private readonly CarBookContext _context;

        public CarPricingRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<CarPricing> GetPricingsWithCars()
        {
            var values = _context.CarPricings.Include(x => x.Pricing).Include(x => x.Car).ThenInclude(b => b.Brand).Where(z => z.PricingId == 2).ToList();
            return values;
        }
    }
}
