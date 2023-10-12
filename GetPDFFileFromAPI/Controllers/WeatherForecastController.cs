using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.IO;
using System.Web.Http;

namespace GetPDFFileFromAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
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

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("/GetPDF")]
        public IHttpActionResult GetBookForHRM()
        {
            string reqBook = "oluwaseun.pdf";
            string path = Path.GetFullPath(reqBook);

            HttpResponseMessage responseMsg = new HttpResponseMessage(HttpStatusCode.OK);
            responseMsg.Content = new StreamContent(new FileStream(path, FileMode.Open, FileAccess.Read));
            return ResponseMessage(responseMsg);
        }
    }
}