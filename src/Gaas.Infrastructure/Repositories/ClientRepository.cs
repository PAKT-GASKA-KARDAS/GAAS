using Gaas.Application.Interfaces;
using Gaas.Application.Models.DTOs;
using Gaas.Infrastructure.Documents;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Gaas.Infrastructure.Repositories;

public class ClientRepository : IClientRepository
{
    private readonly IMongoDatabase _database;
    private IMongoCollection<ClientDocument> _collection;

    public ClientRepository(IMongoDatabase database)
    {
        _database = database;
        _collection = _database.GetCollection<ClientDocument>("clients");
    }

    public async Task<IEnumerable<ClientDto>> GetAllClients()
    {
        var filter = Builders<ClientDocument>.Filter.Empty;
        var documents = await _collection.Find(filter).ToListAsync();

        var clients = documents
            .Select(x => new ClientDto(x.FirstName, x.LastName, x.Height, x.Weight, x.MonthlyGoal, x.DailyIntakes))
            .ToList();

        return clients;
    }

    public async Task<string> AddClient(Domain.Entities.Client client)
    {
        var newClient = new ClientDocument
        {
            Id = ObjectId.GenerateNewId(),
            FirstName = client.FirstName,
            LastName = client.LastName,
            Height = client.Height,
            Weight = client.Weight,
            MonthlyGoal = client.MonthlyGoal,
            DailyIntakes = client.DailyIntakes
        };

        await _collection.InsertOneAsync(newClient);
        return newClient.Id.ToString();
    }
}
