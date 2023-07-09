using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Gaas.ConsoleApp.Models;

internal class Exercise
{
    public ObjectId Id { get; init; }

    [BsonElement("name")]
    public required string Name { get; init; }

    [BsonElement("reps")]
    public required int Reps { get; init; }

    [BsonElement("sets")]
    public required int Sets { get; init; }

    [BsonElement("difficulty")]
    public required string Difficulty { get; init; }
}
