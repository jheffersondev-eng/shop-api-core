using MediatR;
using Shop.Application.WeatherForecasts.Queries;
using Shop.Domain.Entities;

namespace Shop.Application.WeatherForecasts.Handlers;

public sealed class GetWeatherForecastHandler
    : IRequestHandler<GetWeatherForecastQuery, IEnumerable<Shop.Domain.Entities.WeatherForecast>>
{
    public Task<IEnumerable<WeatherForecast>> Handle(
        GetWeatherForecastQuery request,
        CancellationToken cancellationToken)
    {
        var forecasts = Enumerable.Range(1, 5).Select(index => new Shop.Domain.Entities.WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = request.Summaries[Random.Shared.Next(request.Summaries.Length)]
        });

        return Task.FromResult(forecasts);
    }
}
