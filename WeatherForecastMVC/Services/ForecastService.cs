using dotenv.net;
using WeatherForecastMVC.Interfaces;
using WeatherForecastMVC.Models;
using WeatherForecastMVC.Services.Exceptions;

namespace WeatherForecastMVC.Services;

public class ForecastService : IForecastService
{
    private readonly IHttpClientFactory _clientFactory;
    private readonly string? _apiBaseUrl;

    public ForecastService(IHttpClientFactory httpClientFactory)
    {
        DotEnv.Load();

        _clientFactory = httpClientFactory;
        _apiBaseUrl = Environment.GetEnvironmentVariable("API_BASE_URL");
    }

    public async Task<Forecast?> GetForecastByCity(string city)
    {
        if (_apiBaseUrl == null)
        {
            throw new ApiBaseUrlNotFoundException("Configuration not found for API_BASE_URL");
        }

        try
        {
            var client = _clientFactory.CreateClient();

            string url = $"{_apiBaseUrl}?city={city}";

            HttpResponseMessage response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            Forecast? content = await response.Content.ReadFromJsonAsync<Forecast>();

            return content;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}