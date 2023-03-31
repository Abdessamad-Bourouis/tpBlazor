
using BlazorApp.Data;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Pages
{
    public partial class FetchData
    {
        [Inject]  WeatherForecastService WeatherService { get; set; }

        WeatherForecast[] forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await WeatherService.GetForecastAsync(DateTime.Now);
        }


    }
}
