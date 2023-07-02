using WeatherForecastMVC.Models;

namespace WeatherForecastMVC.Interfaces;

public interface IForecastService
{
    public Task<APIForecastModel?> GetForecastByCity(string city);
}
