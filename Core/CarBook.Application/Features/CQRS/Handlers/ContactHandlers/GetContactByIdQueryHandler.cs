using CarBook.Application.Features.CQRS.Queries.ContactQueries;
using CarBook.Application.Features.CQRS.Results.ContactResult;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.ContactHandlers;

public class GetContactByIdQueryHandler
{
    private readonly IRepository<Contact> _repository;

    public GetContactByIdQueryHandler(IRepository<Contact> repository)
    {
        _repository = repository;
    }

    public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery query)
    {
        var value = await _repository.GetByIdAsync(query.Id);
        return new GetContactByIdQueryResult
        {
            Id = value!.Id,
            Email = value.Email,
            Message = value.Message,
            Name = value.Name,
            SendDate = value.SendDate,
            Subject = value.Subject
        };
    }
}
