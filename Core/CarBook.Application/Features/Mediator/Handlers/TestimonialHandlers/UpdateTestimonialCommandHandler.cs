using CarBook.Application.Features.Mediator.Commands.TestimonialCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.TestimonialHandlers;

public class UpdateTestimonialCommandHandler : IRequestHandler<UpdateTestimonialCommand>
{
    private readonly IRepository<Testimonial> _repository;

    public UpdateTestimonialCommandHandler(IRepository<Testimonial> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);

        value!.Name = request.Name;
        value.Title = request.Title;
        value.Description = request.Description;
        value.ImageUrl = request.ImageUrl;
        value.UpdatedDate = DateTime.UtcNow;
        
        await _repository.UpdateAsync(value);
    }
}
