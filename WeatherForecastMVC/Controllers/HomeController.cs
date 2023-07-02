using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WeatherForecastMVC.Interfaces;
using WeatherForecastMVC.Models;
using WeatherForecastMVC.Models.ViewModel;
using WeatherForecastMVC.Services.Exceptions;

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
        if (TempData["ErrorMessage"] is string errorMessage)
        {
            ViewBag.ErrorMessage = errorMessage;
        }

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(SearchViewModel model)
    {
        try
        {
            Forecast? request = await _forecastService.GetForecastByCity(model.City);

            if (request == null)
            {
                return View();
            }

            TempData["APIResponse"] = JsonSerializer.Serialize(request);

            return RedirectToAction("Index", "Forecast");
        }
        catch(ApiBaseUrlNotFoundException ex)
        {
            ViewBag.ApplicationError = ex.Message;
            return View();
        }
        catch (Exception)
        {
            ViewBag.ApplicationError = "An error occurred in the application";
            return View();
        }
    }
}
