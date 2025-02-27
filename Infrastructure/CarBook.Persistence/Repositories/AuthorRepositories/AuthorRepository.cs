using CarBook.Application.Interfaces.AuthorInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories.AuthorRepositories;

public class AuthorRepository : IAuthorRepository
{
    private readonly CarBookContext _context;

    public AuthorRepository(CarBookContext context)
    {
        _context = context;
    }

    public Author GetAuthorByIdWithBlogs(int id)
    {
        var value =  _context.Authors.Include(x => x.Blogs).SingleOrDefault(x => x.Id == id);
        return value!;
    }
}
