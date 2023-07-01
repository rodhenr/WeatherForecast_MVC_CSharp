namespace WeatherForecastMVC.Models;

public class APIForecastModel
{
    public APIForecastModel(string city, string region, string country, string localtime, string lastUpdate, decimal celsiusTemperature, decimal fahrenheitTemperature, string condition, int humidity, List<ForecastList> forecastList)
    {
        City = city;
        Region = region;
        Country = country;
        Localtime = localtime;
        LastUpdate = lastUpdate;
        CelsiusTemperature = celsiusTemperature;
        FahrenheitTemperature = fahrenheitTemperature;
        Condition = condition;
        Humidity = humidity;
        ForecastList = forecastList;
    }

    public string City { get; set; }
    public string Region { get; set; }
    public string Country { get; set; }
    public string Localtime { get; set; }
    public string LastUpdate { get; set; }
    public decimal CelsiusTemperature { get; set; }
    public decimal FahrenheitTemperature { get; set; }
    public string Condition { get; set; }
    public int Humidity { get; set; }
    public List<ForecastList> ForecastList { get; set; }
}
