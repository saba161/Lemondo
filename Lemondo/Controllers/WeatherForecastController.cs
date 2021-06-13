using CRUD_BAL.Interface;
using CRUD_DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemondo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IStatement _statement;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IStatement statement)
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
        public async Task AddStatement([FromBody] Statement statement)
        {
            await _statement.PutStatement(statement);
        }

        [HttpDelete]
        public async Task DeleteStatement(int id)
        {
            await _statement.DeleteStatement(id);
        }

        //[HttpGet]
        //public async Task<IEnumerable<Statement>> GetAllStatement()
        //{
        //    return await _statement.GetStatements();
        //}
    }
}