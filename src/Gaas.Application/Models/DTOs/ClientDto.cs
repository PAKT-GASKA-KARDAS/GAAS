using Gaas.Domain.Entities;

namespace Gaas.Application.Models.DTOs;
public record ClientDto(string FirstName, string LastName, float Height, float Weight, 
    MonthlyGoal? MonthlyGoal, IEnumerable<DailyIntake>? DailyIntakes);