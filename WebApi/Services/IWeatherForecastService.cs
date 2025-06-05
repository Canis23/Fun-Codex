using WebApi.Models;

namespace WebApi.Services;

public interface IWeatherForecastService
{
    IEnumerable<WeatherForecast> GetForecast();
}
