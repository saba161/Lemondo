using Lemondo.Core.Models.Statements;
using Lemondo.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lemondo.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Statement> list = new List<Statement>()
            {
                new Statement("Saba", "hahah", 255),
                new Statement("Saba2", "hahah2", 255)
            };

            var res = new HomeViewModels
            {
                Statements = list.ToList()
            };

            return View(res);
        }

        public IActionResult Details(int id)
        {
            return View();
        }
    }
}