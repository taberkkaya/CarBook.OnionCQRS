﻿using CarBook.Application.Features.Mediator.Queries.AuthorQueries;
using CarBook.Application.Features.Mediator.Results.AuthorResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.AuthorHandlers;

public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, GetAuthorByIdQueryResult>
{
    private readonly IRepository<Author> _repository;

    public GetAuthorByIdQueryHandler(IRepository<Author> repository)
    {
        _repository = repository;
    }

    public async Task<GetAuthorByIdQueryResult> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        return new GetAuthorByIdQueryResult
        {
            Id = value!.Id,
            Name = value.Name,
            ImageUrl = value.ImageUrl,
            Description = value.Description
        };
    }
}
