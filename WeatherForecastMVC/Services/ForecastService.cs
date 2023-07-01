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

    public async Task<APIForecastModel> GetForecastByCity(string city)
    {
        var client = _clientFactory.CreateClient();

        string url = $"http://localhost:5119/api/weatherForecast?city={city}";

        HttpResponseMessage response = await client.GetAsync(url);

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"Invalid request response: {response.StatusCode}");
        }

        APIForecastModel? content = await response.Content.ReadFromJsonAsync<APIForecastModel>();

        return content;
    }
}
