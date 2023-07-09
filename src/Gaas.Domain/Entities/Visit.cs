namespace Gaas.Domain.Entities;
public class Visit
{
    public string Id { get; }
    public string Name { get; private set; }
    public DateTime DateStart { get; private set; }
    public DateTime DateEnd { get; private set; }

    private Visit(string name, DateTime dateStart, DateTime dateEnd)
    {
        Id = Guid.NewGuid().ToString();
        Name = name;
        DateStart = dateStart;
        DateEnd = dateEnd;
    }
    
    private Visit(string id, string name, DateTime dateStart, DateTime dateEnd)
    {
        Id = id;
        Name = name;
        DateStart = dateStart;
        DateEnd = dateEnd;
    }

    public static Visit Create(string name, DateTime dateStart, DateTime dateEnd)
    {
        return new Visit(name, dateStart, dateEnd);
    }

    public static Visit Load(string id, string name, DateTime dateStart, DateTime dateEnd)
    {
        return new Visit(id, name, dateStart, dateEnd);
    }
}
