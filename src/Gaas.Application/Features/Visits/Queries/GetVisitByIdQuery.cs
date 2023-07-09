using Gaas.Application.Models.DTOs;
using MediatR;

namespace Gaas.Application.Features.Visits.Queries;
public record GetVisitByIdQuery(string id) : IRequest<VisitDto>
{
    public static GetVisitByIdQuery Create(string id)
    {
        return new GetVisitByIdQuery(id);
    }
}
