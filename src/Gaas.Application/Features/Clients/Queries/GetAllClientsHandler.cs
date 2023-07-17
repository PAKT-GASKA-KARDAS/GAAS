using Gaas.Application.Interfaces;
using Gaas.Application.Models.DTOs;
using MediatR;

namespace Gaas.Application.Features.Clients.Queries;

public class GetAllClientsHandler : IRequestHandler<GetAllClientsQuery, IEnumerable<ClientDto>>
{
    private readonly IClientRepository _repository;

    public GetAllClientsHandler(IClientRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<ClientDto>> Handle(GetAllClientsQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetAllClients();
    }
}
