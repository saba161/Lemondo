using Lemondo.Core.Models.Statements;
using Lemondo.UI.Extentions;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lemondo.UI.Controllers
{
    public class CrudController : Controller
    {
        private readonly HttpClient _client;
        public CrudController(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("api");
        }

        [HttpGet]
        [Route("/crud/getStatement")]
        public async Task<IActionResult> GetStatement()
        {
            var statement = await _client.GetListAsync<Statement>($"api/WeatherForecast/GetStamenet");
            return View(statement);
        }
    }
}