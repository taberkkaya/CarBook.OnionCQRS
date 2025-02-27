using CarBook.Application.Features.Mediator.Commands.AuhorCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.AuthorHandlers;

public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand>
{
    private readonly IRepository<Author> _repository;

    public UpdateAuthorCommandHandler(IRepository<Author> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);

        value!.Name = request.Name;
        value.Description = request.Description;    
        value.ImageUrl = request.ImageUrl;
        value.UpdatedDate = DateTime.Now;
    
        await _repository.UpdateAsync(value);
    }
}
