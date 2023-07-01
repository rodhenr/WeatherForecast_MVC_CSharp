using System.ComponentModel.DataAnnotations;

namespace WeatherForecastMVC.Models.ViewModel;

public class SearchViewModel
{
    [Required(ErrorMessage = "This field is required")]
    [MinLength(3)]
    public string? City { get; set; }
}
