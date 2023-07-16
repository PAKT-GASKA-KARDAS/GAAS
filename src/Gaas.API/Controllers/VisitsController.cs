using Gaas.Application.Features.Parameters;
using Gaas.Application.Features.Visits.Commands;
using Gaas.Application.Features.Visits.Queries;
using Gaas.Application.Models.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Gaas.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VisitsController : ControllerBase
{
    private readonly IMediator _mediator;

    public VisitsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<VisitDto>>> GetAllVisits()
    {
        var query = GetAllVisitsQuery.Create();
        var response = await _mediator.Send(query);
        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<VisitDto>> GetVisitById(string id)
    {
        var query = GetVisitByIdQuery.Create(id);
        var response = await _mediator.Send(query);
        return Ok(response);
    }

    [HttpPost]
    public async Task<ActionResult<string>> AddVisit(AddVisitCommandParameters request)
    {
        var command = AddVisitCommand.Create(request);
        var response = await _mediator.Send(command);
        return CreatedAtAction(nameof(AddVisit), response);
    }
}
