using Gaas.Application.Models.DTOs;
using Gaas.Domain.Entities;

namespace Gaas.Application.Interfaces;
public interface IVisitRepository
{
    Task<IEnumerable<VisitDto>> GetAllVisits();
    Task<string> AddVisit(Visit visit);
    Task<VisitDto> GetVisitById(string id);
}
