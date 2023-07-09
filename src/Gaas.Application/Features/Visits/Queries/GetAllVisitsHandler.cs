using Gaas.Application.Features.Visits.Queries;
using Gaas.Application.Interfaces;
using Gaas.Application.Models.DTOs;
using MediatR;

namespace Gaas.Application.Features.Visits.Queries;
public class GetAllVisitsHandler : IRequestHandler<GetAllVisitsQuery, IEnumerable<VisitDto>>
{
    private readonly IVisitRepository _repository;

    public GetAllVisitsHandler(IVisitRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<VisitDto>> Handle(GetAllVisitsQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetAllVisits();
    }
}
