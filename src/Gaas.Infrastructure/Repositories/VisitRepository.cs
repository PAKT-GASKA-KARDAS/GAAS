using Gaas.Application.Interfaces;
using Gaas.Application.Models.DTOs;
using Gaas.Infrastructure.Documents;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Gaas.Infrastructure.Repositories;
public class VisitRepository : IVisitRepository
{
    private readonly IMongoDatabase _database;
    private IMongoCollection<VisitDocument> _collection;

    public VisitRepository(IMongoDatabase database)
    {
        _database = database;
        _collection = _database.GetCollection<VisitDocument>("visits");
    }

    public async Task<IEnumerable<VisitDto>> GetAllVisits()
    {
        var filter = Builders<VisitDocument>.Filter.Empty;
        var documents = await _collection.Find(filter).ToListAsync();

        var visits = documents
            .Select(x => new VisitDto(x.Name, x.EnterDate, x.LeaveDate))
            .ToList();

        return visits;
    }

    public async Task<VisitDto> GetVisitById(string id)
    {
        var collection = _database.GetCollection<VisitDocument>("visits");

        var objectId = new ObjectId(id);
        var filter = Builders<VisitDocument>.Filter.Eq(v => v.Id, objectId);
        var document = await collection.Find(filter).FirstOrDefaultAsync();

        return new VisitDto(document.Name, document.EnterDate, document.LeaveDate);
    }

    public async Task<string> AddVisit(Domain.Entities.Visit visit)
    {
        var collection = _database.GetCollection<VisitDocument>("visits");

        var newVisit = new VisitDocument
        {
            Id = ObjectId.GenerateNewId(),
            Name = visit.Name,
            EnterDate = DateTime.UtcNow,
            LeaveDate = DateTime.UtcNow.AddMinutes(30)
        };

        await collection.InsertOneAsync(newVisit);
        return newVisit.Id.ToString();
    }
}
