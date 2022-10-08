using Microsoft.AspNetCore.Mvc;

namespace Hypance.WebApi.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    [HttpPost(Name = "PostWeatherForecast")]
    public ActionResult PostFrontendTest(FrontendTest model)
    {
        var test = model;

        return Ok();
    }


    public class FrontendTest
    {
        public string StrategyName { get; set; }
        public string StrategyDescription { get; set; }
        public string SignalName { get; set; }
        public string Period { get; set; }
        public string Indicator { get; set; }
        public string Setting { get; set; }
        public string StrategyTrend { get; set; }
    }
}

