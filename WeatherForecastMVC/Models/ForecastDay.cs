using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WeatherForecastMVC.Models;

public class ForecastDay
{
    public ForecastDay(DateTime date, decimal maxTempCelsius, decimal minTempCelsius, decimal maxTempFahrenheit, decimal minTempFahrenheit, decimal totalPrecipitationMm, string condition, string icon)
    {
        Date = date;
        MaxTempCelsius = maxTempCelsius;
        MinTempCelsius = minTempCelsius;
        MaxTempFahrenheit = maxTempFahrenheit;
        MinTempFahrenheit = minTempFahrenheit;
        TotalPrecipitationMm = totalPrecipitationMm;
        Condition = condition;
        Icon = icon;
    }

    public DateTime Date { get; set; }

    public decimal MaxTempCelsius { get; set; }

    public decimal MinTempCelsius { get; set; }

    public decimal MaxTempFahrenheit { get; set; }

    public decimal MinTempFahrenheit { get; set; }

    public decimal TotalPrecipitationMm { get; set; }

    public string Condition { get; set; }

    public string Icon { get; set; }
}
