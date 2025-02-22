﻿using CarBook.Application.Features.CQRS.Commands.AboutCommands;
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
        var value = await _repository.GetByIdAsync(command.Id);

        value!.Title = command.Title;
        value.Description = command.Description;
        value.ImageUrl = command.ImageUrl;
        value.UpdatedDate = DateTime.Now;

        await _repository.UpdateAsync(value);
    }
}
