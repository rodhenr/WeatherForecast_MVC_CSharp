using WeatherForecastMVC.Models;

namespace WeatherForecastMVC.Interfaces;

public interface IForecastService
{
    public Task<Forecast?> GetForecastByCity(string city);
}
