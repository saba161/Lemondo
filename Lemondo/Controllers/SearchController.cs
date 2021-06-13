using Lemondo.Core.Models.Statements;
using Lemondo.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Lemondo.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class SearchController : ControllerBase
    {
        private readonly ILogger<SearchController> _logger;
        private readonly ISearchSerivce _search;

        public SearchController(ILogger<SearchController> logger, ISearchSerivce search)
        {
            _search = search;
            _logger = logger;
        }

        [HttpGet]
        public async Task<Statement> SearchByName(string name)
        {
            return await _search.SearchByName(name);
        }
    }
}
