using MediatR;
using Microsoft.AspNetCore.Mvc;
using Saturn.Application.Dtos;
using Saturn.Application.Features;

namespace Saturn.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IMediator _mediator;
    public WeatherForecastController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("get")]
    public Task<int> Get(TestDto dto) => 
        _mediator.Send(new TestQuery(dto));
}