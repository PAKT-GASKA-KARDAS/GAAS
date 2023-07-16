using Gaas.Application.Models.DTOs;
using Gaas.Domain.Entities;

namespace Gaas.Application.Interfaces;

public interface IClientRepository
{
    Task<string> AddClient(Client client);
    Task<IEnumerable<ClientDto>> GetAllClients();
}
