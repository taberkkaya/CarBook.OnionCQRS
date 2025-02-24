using CarBook.Application.Features.Mediator.Commands.FooterAddressComands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.FooterAddressHandlers;

public class CreateFooterAddressCommandHandler : IRequestHandler<CreateFooterAddressCommand>
{
    private readonly IRepository<FooterAddress> _repository;

    public CreateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateFooterAddressCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(new FooterAddress
        {
            Description = request.Description,
            Address = request.Address,
            PhoneNumber = request.PhoneNumber,
            Email = request.Email,
            CreatedDate = DateTime.Now
        });
    }
}
