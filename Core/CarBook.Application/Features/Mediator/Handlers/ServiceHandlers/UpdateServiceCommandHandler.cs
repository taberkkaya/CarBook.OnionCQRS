using CarBook.Application.Features.Mediator.Commands.ServiceCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.ServiceHandlers;

public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommand>
{
    private readonly IRepository<Service> _repository;

    public UpdateServiceCommandHandler(IRepository<Service> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);

        value!.Title = request.Title;
        value.Description = request.Description;
        value.IconUrl = request.IconUrl;
        value.UpdatedDate = DateTime.Now;

        await _repository.UpdateAsync(value);
    }
}
