using Lemondo.Core.Models.Statements;
using Lemondo.UI.Extentions;
using Lemondo.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lemondo.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HttpClient _client;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory factory)
        {
            _logger = logger;
            _client = factory.CreateClient("api");
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var statement = await _client.GetListAsync<Statement>($"api/WeatherForecast/GetAllStatement");

            return View(new HomeViewModels { Statements = statement });
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var statement = await _client.GetAsync<Statement>($"api/WeatherForecast/GetStamenet?id={id}");
            if (statement == null)
            {
                return NotFound();
            }

            return View(statement);
        }

        [HttpPost]
        public async Task<IActionResult> Search(string name)
        {
            var statement = await _client.GetAsync<Statement>($"api/WeatherForecast/SearchByName?name={name}");
            if (statement == null)
            {
                return View(statement);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Search()
        {
            return View();
        }
    }
}