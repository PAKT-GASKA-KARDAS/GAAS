using Gaas.Application.Features.Parameters;
using MediatR;

namespace Gaas.Application.Features.Clients.Commands;

public record AddClientCommand(string firstName, string lastName, float weight, float height) 
    : IRequest<string>
{
    public static AddClientCommand Create(AddClientCommandParameters parameters)
    {
        return new AddClientCommand(parameters.FirstName, parameters.LastName, parameters.Weight, parameters.Height);
    }
}