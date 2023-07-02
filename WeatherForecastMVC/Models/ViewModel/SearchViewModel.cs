using System.ComponentModel.DataAnnotations;

namespace WeatherForecastMVC.Models.ViewModel;

public class SearchViewModel
{
    [Required(ErrorMessage = "{0} required")]
    [MinLength(3, ErrorMessage = "{0} size should be at least {1}")]
    public required string City { get; set; }
}
