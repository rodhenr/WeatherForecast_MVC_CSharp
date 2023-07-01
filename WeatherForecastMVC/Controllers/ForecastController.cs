using Microsoft.AspNetCore.Mvc;
using WeatherForecastMVC.Interfaces;
using WeatherForecastMVC.Models;

namespace WeatherForecastMVC.Controllers;
public class ForecastController : Controller
{
    private readonly IForecastService _forecastService;

    public ForecastController(IForecastService forecastService)
    {
        _forecastService = forecastService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> SearchCity(string city)
    {
        APIForecastModel request = await _forecastService.GetForecastByCity(city);

        return RedirectToAction("Index", request);
    }
}
