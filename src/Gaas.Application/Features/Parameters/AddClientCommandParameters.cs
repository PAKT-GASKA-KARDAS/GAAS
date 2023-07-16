namespace Gaas.Application.Features.Parameters;

public class AddClientCommandParameters
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public float Weight { get; set; }
    public float Height { get; set; }
}
