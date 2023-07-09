using Gaas.Application.Interfaces;
using MediatR;

namespace Gaas.Application.Features.Visits.Commands;
public class AddVisitHandler : IRequestHandler<AddVisitCommand, string>
{
    private readonly IVisitRepository _repository;

    public AddVisitHandler(IVisitRepository repository)
    {
        _repository = repository;
    }

    public async Task<string> Handle(AddVisitCommand request, CancellationToken cancellationToken)
    {
        var visit = Gaas.Domain.Entities.Visit.Create(request.Name, request.DateStart, request.DateEnd);
        var visitId = await _repository.AddVisit(visit);
        return visitId;
    }
}
