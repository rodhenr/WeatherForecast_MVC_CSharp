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

    public async Task<APIForecastModel?> GetForecastByCity(string city)
    {
        var client = _clientFactory.CreateClient();

        string url = $"http://localhost:5119/api/weatherForecast?city={city}";

        HttpResponseMessage response = await client.GetAsync(url);

        if (!response.IsSuccessStatusCode)
        {
            return null;
        }

        APIForecastModel? content = await response.Content.ReadFromJsonAsync<APIForecastModel>();

        return content;
    }
}

// Quero saber quando a cidade é inválida para dizer para o usuário que não foi encontrado dados
// Não permitir input com menos de 3 caracteres
// Melhorar design do forecast direito
// Adicionar lógica de Celsius/Fahrenheit
// Adicionar lógica de idiomas PT-BR/EN-US
// Fundo de acordo com o tipo de condição climática
// Achar e usar ícones para cada condição climática (criar ENUM)
// Preciso de construtor para meu model?
// Tem problema em ter propriedades nullable? É o que eu quero?
// Tem como mexer no link ao pesquisar?
// Testar e arrumar possíveis erros que possam vir da API e bad request no front-end (tipo quando a API estiver off)
// E se eu colocar uma cidade padrão para ter sempre um model válido? (tipo São Paulo)