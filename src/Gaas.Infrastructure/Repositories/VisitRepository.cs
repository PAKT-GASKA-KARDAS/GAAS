using Gaas.Application.Interfaces;
using Gaas.Application.Models.DTOs;
using Gaas.Infrastructure.Documents;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Gaas.Infrastructure.Repositories;
public class VisitRepository : IVisitRepository
{
    private readonly IMongoDatabase _database;

    public VisitRepository(IMongoDatabase database)
    {
        _database = database;
    }

    public async Task<IEnumerable<VisitDto>> GetAllVisits()
    {
        var collection = _database.GetCollection<VisitDocument>("visits");

        var filter = Builders<VisitDocument>.Filter.Empty;
        var documents = await collection.Find(filter).ToListAsync();

        var visits = documents
            .Select(x => new VisitDto(x.Name, x.DateStart, x.DateEnd))
            .ToList();

        return visits;
    }

    public async Task<VisitDto> GetVisitById(string id)
    {
        var collection = _database.GetCollection<VisitDocument>("visits");

        var objectId = new ObjectId(id);
        var filter = Builders<VisitDocument>.Filter.Eq(v => v.Id, objectId);
        var document = await collection.Find(filter).FirstOrDefaultAsync();

        return new VisitDto(document.Name, document.DateStart, document.DateEnd);
    }

    public async Task<string> AddVisit(Domain.Entities.Visit visit)
    {
        var collection = _database.GetCollection<VisitDocument>("visits");

        var newVisit = new VisitDocument
        {
            Id = ObjectId.GenerateNewId(),
            Name = visit.Name,
            DateStart = DateTime.UtcNow,
            DateEnd = DateTime.UtcNow.AddMinutes(30)
        };

        await collection.InsertOneAsync(newVisit);
        return newVisit.Id.ToString();
    }
}
