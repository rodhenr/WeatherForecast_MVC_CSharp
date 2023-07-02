using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WeatherForecastMVC.Models;
using WeatherForecastMVC.Models.ViewModel;

namespace WeatherForecastMVC.Controllers;

public class ForecastController : Controller
{
    public ForecastController()
    {
    }

    public IActionResult Index()
    {
        try
        {
            if (TempData["APIResponse"] is not string serializedData)
            {
                TempData["ErrorMessage"] = "Invalid data received from request";

                return RedirectToAction("Index", "Home");
            }

            Forecast? forecastData = JsonSerializer.Deserialize<Forecast>(serializedData);

            if (forecastData is null)
            {
                TempData["ErrorMessage"] = "Invalid data received from request";

                return RedirectToAction("Index", "Home");
            }

            return View(forecastData);
        }
        catch (JsonException)
        {
            TempData["ErrorMessage"] = "Invalid data received from request";

            return RedirectToAction("Index", "Home");
        }
    }
}