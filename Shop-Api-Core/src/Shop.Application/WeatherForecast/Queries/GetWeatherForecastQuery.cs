using MediatR;
using Shop.Domain.Entities;

namespace Shop.Application.WeatherForecasts.Queries;

public sealed record GetWeatherForecastQuery(string[] Summaries)
    : IRequest<IEnumerable<Shop.Domain.Entities.WeatherForecast>>;
