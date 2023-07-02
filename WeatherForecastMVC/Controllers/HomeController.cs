using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WeatherForecastMVC.Interfaces;
using WeatherForecastMVC.Models;
using WeatherForecastMVC.Models.ViewModel;
using WeatherForecastMVC.Services;

namespace WeatherForecastMVC.Controllers;
public class HomeController : Controller
{
    private readonly IForecastService _forecastService;

    public HomeController(IForecastService forecastService)
    {
        _forecastService = forecastService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(SearchViewModel? model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        APIForecastModel? request = await _forecastService.GetForecastByCity(model.City);

        TempData["APIResponse"] = JsonSerializer.Serialize(request);

        if(request == null)
        {
            return View();
        }

        return RedirectToAction("Index", "Forecast");
    }
}
