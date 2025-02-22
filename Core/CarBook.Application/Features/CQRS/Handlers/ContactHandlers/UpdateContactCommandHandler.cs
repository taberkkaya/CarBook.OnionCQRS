using CarBook.Application.Features.CQRS.Commands.ContactCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.ContactHandlers;

public class UpdateContactCommandHandler
{
    private readonly IRepository<Contact> _repository;

    public UpdateContactCommandHandler(IRepository<Contact> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateContactCommand command)
    {
        var value = await _repository.GetByIdAsync(command.Id);

        value!.Name = command.Name;
        value.Email = command.Email;
        value.Subject = command.Subject;
        value.UpdatedDate = DateTime.Now;

        await _repository.UpdateAsync(value);
    }
}
