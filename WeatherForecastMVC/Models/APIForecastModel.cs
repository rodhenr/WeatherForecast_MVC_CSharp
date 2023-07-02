using System.Text.Json.Serialization;

namespace WeatherForecastMVC.Models;

public class APIForecastModel
{
    public APIForecastModel()
    {
    }

    public string? City { get; set; }
    public string? Region { get; set; }
    public string? Country { get; set; }
    public string? Localtime { get; set; }
    public string? LastUpdate { get; set; }
    public decimal CelsiusTemperature { get; set; }
    public decimal FahrenheitTemperature { get; set; }
    public string? Condition { get; set; }
    public int Humidity { get; set; }
    public List<ForecastList>? ForecastList { get; set; }    
}
