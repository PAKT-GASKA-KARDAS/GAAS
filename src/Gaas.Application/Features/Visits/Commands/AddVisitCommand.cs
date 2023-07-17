using Gaas.Application.Features.Parameters;
using MediatR;

namespace Gaas.Application.Features.Visits.Commands;
public record AddVisitCommand(string Name, DateTime DateStart, DateTime DateEnd) : IRequest<string>
{
    public static AddVisitCommand Create(AddVisitCommandParameters parameters)
    {
        return new AddVisitCommand(parameters.Name, parameters.DateStart, parameters.DateEnd);
    }
}
