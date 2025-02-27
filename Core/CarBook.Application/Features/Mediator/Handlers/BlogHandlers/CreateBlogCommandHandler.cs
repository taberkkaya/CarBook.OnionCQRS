using CarBook.Application.Features.Mediator.Commands.BlogCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers;

public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand>
{
    private readonly IRepository<Blog> _repository;

    public CreateBlogCommandHandler(IRepository<Blog> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateBlogCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(new Blog
        {
            AuthorId = request.AuthorId,
            CategoryId = request.CategoryId,
            CoverImgUrl = request.CoverImgUrl,
            Title = request.Title,
            CreatedDate = DateTime.Now
        });
    }
}
