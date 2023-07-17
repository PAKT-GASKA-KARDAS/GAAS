using Gaas.Application.Features.Clients.Commands;
using Gaas.Application.Features.Clients.Queries;
using Gaas.Application.Features.Parameters;
using Gaas.Application.Models.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Gaas.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ClientsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ClientDto>>> GetAllClients()
    {
        var query = GetAllClientsQuery.Create();
        var response = await _mediator.Send(query);
        return Ok(response);
    }

    [HttpPost]
    public async Task<ActionResult<string>> AddClient(AddClientCommandParameters request)
    {
        var command = AddClientCommand.Create(request);
        var response = await _mediator.Send(command);
        return CreatedAtAction(nameof(AddClient), response);
    }
}
