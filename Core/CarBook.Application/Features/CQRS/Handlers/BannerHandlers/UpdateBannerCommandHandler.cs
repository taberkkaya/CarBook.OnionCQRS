﻿using CarBook.Application.Features.CQRS.Commands.BannerCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.BannerHandlers;

public class UpdateBannerCommandHandler
{
    private readonly IRepository<Banner> _repository;

    public UpdateBannerCommandHandler(IRepository<Banner> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateBannerCommand command)
    {
        var value = await _repository.GetByIdAsync(command.Id);

        value!.Id = command.Id;
        value.Title = command.Title;
        value.Description = command.Description;
        value.VideoDescription = command.VideoDescription;
        value.VideoUrl = command.VideoUrl;
        value.UpdatedDate = DateTime.Now;

        await _repository.UpdateAsync(value);
    }
}
