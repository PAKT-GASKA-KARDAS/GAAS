using Gaas.Application.Models.DTOs;
using MediatR;

namespace Gaas.Application.Features.Clients.Queries;

public record GetAllClientsQuery : IRequest<IEnumerable<ClientDto>>
{
    public static GetAllClientsQuery Create()
    {
        return new GetAllClientsQuery();
    }
}