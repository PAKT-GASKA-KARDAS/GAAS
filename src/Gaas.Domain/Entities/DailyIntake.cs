namespace Gaas.Domain.Entities;

public class DailyIntake
{
    public string Id { get; }
    public DateTime Date { get; private set; }    
    public float Calories { get; private set; }
    public float Proteins { get; private set; }
    public float Carbs { get; private set; }
    public float Fats { get; private set; }

    public string ClientId { get; private set; }
}
