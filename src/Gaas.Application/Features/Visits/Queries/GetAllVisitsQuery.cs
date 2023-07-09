using Gaas.Application.Models.DTOs;
using MediatR;

namespace Gaas.Application.Features.Visits.Queries;
public class GetAllVisitsQuery : IRequest<IEnumerable<VisitDto>>
{
    public static GetAllVisitsQuery Create()
    {
        return new GetAllVisitsQuery();
    }
}
