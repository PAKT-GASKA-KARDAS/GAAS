namespace Gaas.Application.Features.Parameters;
public class AddVisitCommandParameters
{
    public string Name { get; set; } = string.Empty;
    public DateTime DateStart { get; set; }
    public DateTime DateEnd { get; set; }
}
