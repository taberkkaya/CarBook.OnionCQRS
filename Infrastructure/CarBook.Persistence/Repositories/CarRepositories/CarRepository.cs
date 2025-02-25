using System.Linq;
using CarBook.Application.Interfaces.CarInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories.CarRepositories;

public class CarRepository : ICarRepository
{
    private readonly CarBookContext _context;

    public CarRepository(CarBookContext context)
    {
        _context = context;
    }

    public List<Car> GetCarsListWithBrand()
    {
        var values = _context.Cars.Include(x => x.Brand).ToList();
        return values;
    }

    public List<Car> GetLast5CarsListWithBrand()
    {
        var values = _context.Cars.OrderByDescending(x => x.Id).Take(5).Include(_x => _x.Brand).ToList();
        return values;
    }
}
