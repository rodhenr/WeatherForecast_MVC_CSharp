namespace WeatherForecastMVC.Services.Exceptions;

public class ApiBaseUrlNotFoundException: Exception
{
    public ApiBaseUrlNotFoundException(string message): base(message)
    {
        
    }
}
