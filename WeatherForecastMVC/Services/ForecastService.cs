using WeatherForecastMVC.Interfaces;
using WeatherForecastMVC.Models;

namespace WeatherForecastMVC.Services;

public class ForecastService : IForecastService
{
    private readonly IHttpClientFactory _clientFactory;

    public ForecastService(IHttpClientFactory httpClientFactory)
    {
        _clientFactory = httpClientFactory;
    }

    public async Task<Forecast?> GetForecastByCity(string city)
    {
        try
        {
            var client = _clientFactory.CreateClient();

            string url = $"http://localhost:5119/api/weatherForecast?city={city}";

            HttpResponseMessage response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            Forecast? content = await response.Content.ReadFromJsonAsync<Forecast>();

            return content;
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }        
    }
}