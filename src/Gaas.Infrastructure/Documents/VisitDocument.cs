using MongoDB.Bson;

namespace Gaas.Infrastructure.Documents;
internal class VisitDocument
{
    public ObjectId Id { get; set; }
    public string Name { get; set; }
    public DateTime DateStart { get; set; }
    public DateTime DateEnd { get; set; }
}
