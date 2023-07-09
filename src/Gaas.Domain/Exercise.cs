namespace Gaas.Domain;

public class Exercise
{
    public required string Id { get; init; }
    public required string Name { get; init; } 
    public required int Reps { get; init; }
    public required int Sets { get; init; }
    public required string Difficulty { get; init; } 
}
