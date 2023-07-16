namespace Gaas.Domain.Entities;

public class Client
{
    public string Id { get; set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public float Height { get; private set; }
    public float Weight { get; private set; }
    public MonthlyGoal MonthlyGoal { get; set; }
    public IEnumerable<DailyIntake> DailyIntakes { get; set; }

    private Client(string firstName, string lastName, float weight, float height)
    {
        Id = Guid.NewGuid().ToString();
        FirstName = firstName;
        LastName = lastName;
        Weight = weight;
        Height = height;
    }

    private Client(string firstName, string lastName, float weight, float height,
        MonthlyGoal monthlyGoal, IEnumerable<DailyIntake> dailyIntakes)
    {
        Id = Guid.NewGuid().ToString();
        FirstName = firstName;
        LastName = lastName;
        Weight = weight;
        Height = height;
        MonthlyGoal = monthlyGoal;
        DailyIntakes = dailyIntakes;
    }

    public static Client Create(string firstName, string lastName, float weight, float height)
    {
        return new Client(firstName, lastName, weight, height);
    }

    public static Client Load(string firstName, string lastName, float weight, float height,
        MonthlyGoal monthlyGoal, IEnumerable<DailyIntake> dailyIntakes)
    {
        return new Client(firstName, lastName, weight, height, monthlyGoal, dailyIntakes);
    }
}
