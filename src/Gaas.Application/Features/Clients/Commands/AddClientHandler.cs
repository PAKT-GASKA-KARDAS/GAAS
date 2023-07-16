using Gaas.Application.Interfaces;
using MediatR;

namespace Gaas.Application.Features.Clients.Commands;

public class AddClientHandler : IRequestHandler<AddClientCommand, string>
{
    private readonly IClientRepository _repository;

    public AddClientHandler(IClientRepository repository)
    {
        _repository = repository;
    }

    public async Task<string> Handle(AddClientCommand request, CancellationToken cancellationToken)
    {
        var client = Gaas.Domain.Entities.Client.Create(request.firstName, request.lastName, request.weight, request.height);
        var clientId = await _repository.AddClient(client);
        return clientId;
    }
}
