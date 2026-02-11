using Microsoft.AspNetCore.Mvc;
using MediatR;
using Shop.Domain.Entities;
using Shop.Application.WeatherForecasts.Queries;

namespace Shop.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IMediator _mediator;

        public UserController(
            ILogger<UserController> logger,
            IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet(Name = "GetUser")]
        public async Task<IEnumerable<WeatherForecast>> Get(CancellationToken cancellationToken)
        {
            var request = new GetWeatherForecastQuery([]);
            return await _mediator.Send(request, cancellationToken);
        }
    }
}
