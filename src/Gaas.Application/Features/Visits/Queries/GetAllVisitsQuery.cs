using Gaas.Application.Models.DTOs;
using MediatR;

namespace Gaas.Application.Features.Visits.Queries;
public record GetAllVisitsQuery : IRequest<IEnumerable<VisitDto>>
{
    public static GetAllVisitsQuery Create()
    {
        return new GetAllVisitsQuery();
    }
}
