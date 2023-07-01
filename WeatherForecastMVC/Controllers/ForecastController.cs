using Microsoft.AspNetCore.Mvc;
using WeatherForecastMVC.Interfaces;
using WeatherForecastMVC.Models;
using WeatherForecastMVC.Models.ViewModel;

namespace WeatherForecastMVC.Controllers;
public class ForecastController : Controller
{
    private readonly IForecastService _forecastService;

    public ForecastController(IForecastService forecastService)
    {
        _forecastService = forecastService;
    }

    public IActionResult Index(APIForecastModel? apiResult)
    {
        return View(apiResult);
    }

    [HttpPost]
    public async Task<IActionResult> Index(SearchViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return RedirectToAction("Index", "Home", model);
        }

        APIForecastModel? request = await _forecastService.GetForecastByCity(model.City);

        return View(request);
    }
}
