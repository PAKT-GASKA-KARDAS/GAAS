using MongoDB.Bson;

namespace Gaas.Infrastructure.Documents;
internal class VisitDocument
{
    public ObjectId Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime EnterDate { get; set; }
    public DateTime LeaveDate { get; set; }
}
