using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WeatherForecastMVC.Models;

namespace WeatherForecastMVC.Controllers;
public class ForecastController : Controller
{
    public ForecastController()
    {
    }

    public IActionResult Index()
    {
        string? serializedData = TempData["APIResponse"] as string;

        if (TempData["APIResponse"] != null & serializedData != null)
        {
            APIForecastModel forecastData = JsonSerializer.Deserialize<APIForecastModel>(serializedData);

            return View(forecastData);
        }

        return RedirectToAction("Index", "Home");
    }
}

