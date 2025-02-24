using CarBook.Application.Features.Mediator.Commands.FooterAddressComands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.FooterAddressHandlers;

public class UpdateFooterAddressCommandHandler : IRequestHandler<UpdateFooterAddressCommand>
{
    private readonly IRepository<FooterAddress> _repository;

    public UpdateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);

        value!.Description = request.Description;
        value.Address = request.Address;
        value.PhoneNumber = request.PhoneNumber;
        value.Email = request.Email;
        value.UpdatedDate = DateTime.Now;

        await _repository.UpdateAsync(value);
    }
}
