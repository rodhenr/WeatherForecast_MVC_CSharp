using Microsoft.AspNetCore.Mvc;
using WeatherForecastMVC.Interfaces;
using WeatherForecastMVC.Models;
using WeatherForecastMVC.Models.ViewModel;

namespace WeatherForecastMVC.Controllers;
public class HomeController : Controller
{
    public HomeController()
    {
    }

    public IActionResult Index()
    {
        return View();
    }
}
