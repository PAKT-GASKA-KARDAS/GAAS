namespace Gaas.Application.Features.Models;
public class AddVisitCommandParameters
{
    public string Name { get; set; } = string.Empty;
    public DateTime DateStart { get; set; }
    public DateTime DateEnd { get; set; }
}
