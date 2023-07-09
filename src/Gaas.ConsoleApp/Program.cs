using Gaas.ConsoleApp.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.CodeDom.Compiler;

internal class Program
{
    private static void Main(string[] args)
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

        exercisesCollection.InsertOne(newExercise);

        var exercises = exercisesCollection
            .Find(_ => true)
            .ToList();

        exercises.ForEach(e => Console.WriteLine(e.ToBsonDocument<Exercise>()));
    }
}