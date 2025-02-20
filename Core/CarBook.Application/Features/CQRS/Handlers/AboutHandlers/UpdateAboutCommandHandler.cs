using CarBook.Application.Features.CQRS.Commands.AboutCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandlers;

public class UpdateAboutCommandHandler
{
    private readonly IRepository<About> _repository;

    public UpdateAboutCommandHandler(IRepository<About> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateAboutCommand command)
    {
        var values = await _repository.GetByIdAsync(command.Id);

        values!.Title = command.Title;
        values.Description = command.Description;
        values.ImageUrl = command.ImageUrl;
        values.UpdatedDate = DateTime.Now;

        await _repository.UpdateAsync(values);
    }
}
