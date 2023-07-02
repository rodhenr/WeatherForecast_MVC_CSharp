namespace WeatherForecastMVC.Models;

public class Forecast
{
    public Forecast()
    {
    }

    public required string City { get; set; }
    public required string Region { get; set; }
    public required string Country { get; set; }
    public required string Localtime { get; set; }
    public required string LastUpdate { get; set; }
    public required decimal CelsiusTemperature { get; set; }
    public required decimal FahrenheitTemperature { get; set; }
    public required string Condition { get; set; }
    public required int Humidity { get; set; }
    public required List<ForecastDay> ForecastList { get; set; }    
}
