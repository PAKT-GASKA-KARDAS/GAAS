using Gaas.ConsoleApp.Models;
using MongoDB.Driver;

namespace Gaas.ConsoleApp.Services;

internal class ExerciseService
{
    public async Task AddExercise()
    {
        string connectionString = "mongodb://localhost";

        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("gaas");
        var exercisesCollection = database.GetCollection<Exercise>("exercises");

        Exercise newExercise = new()
        {
            ExerciseId = Guid.NewGuid().ToString(),
            Name = "Bench Press",
            Reps = 10,
            Sets = 4,
            Difficulty = "beginner"
        };

        await exercisesCollection.InsertOneAsync(newExercise);
    }

}
