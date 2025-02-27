using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces.AuthorInterfaces;

public interface IAuthorRepository
{
    Author GetAuthorByIdWithBlogs(int id);
}
