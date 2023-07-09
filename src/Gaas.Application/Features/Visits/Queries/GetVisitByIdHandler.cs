using Gaas.Application.Interfaces;
using Gaas.Application.Models.DTOs;
using MediatR;

namespace Gaas.Application.Features.Visits.Queries;
public class GetVisitByIdHandler : IRequestHandler<GetVisitByIdQuery, VisitDto>
{
    private readonly IVisitRepository _repository;

    public GetVisitByIdHandler(IVisitRepository visitRepository)
    {
        _repository = visitRepository;
    }

    public async Task<VisitDto> Handle(GetVisitByIdQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetVisitById(request.id);
    }
}
