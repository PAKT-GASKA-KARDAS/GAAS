using Gaas.Domain.Entities;
using MongoDB.Bson;

namespace Gaas.Infrastructure.Documents;

public class ClientDocument
{
    public ObjectId Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public float Height { get; set; }
    public float Weight { get; set; }
    public MonthlyGoal? MonthlyGoal { get; set; }
    public IEnumerable<DailyIntake>? DailyIntakes { get; set; }
}
