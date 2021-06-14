using Lemondo.Core.Models.Statements;
using Lemondo.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lemondo.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IStatementService _statement;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IStatementService statement)
        {
            _statement = statement;
            _logger = logger;
        }

        [HttpGet]
        public async Task<Statement> GetStamenet(int id)
        {
            return await _statement.GetStatementById(id);
        }

        [HttpPut]
        public async Task PutStatement([FromBody] Statement statement)
        {
            await _statement.PutStatement(statement);
        }

        [HttpDelete]
        public async Task DeleteStatement(int id)
        {
            await _statement.DeleteStatement(id);
        }

        [HttpGet]
        public async Task<IEnumerable<Statement>> GetAllStatement()
        {
            return await _statement.GetStatements();
        }
    }
}