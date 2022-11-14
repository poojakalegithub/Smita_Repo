using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCalculator.Models;

namespace WebApplicationCalculator.Controllers
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
            return View();
        }

        [HttpPost]
        public IActionResult Index(Calculator calc)
        {
            int num1 = calc.value1;
            int num2= calc.value2;
            switch (calc.calculate)
            {
                case "add":
                    calc.result = num1 + num2;
                    break;
                case "sub":
                    calc.result = num1 - num2;
                    break;
                case "Multiply":
                    calc.result = num1 * num2;
                    break;
                case "Divide":
                    calc.result = num1 / num2;
                    break;
                default:
                    calc.result = 0;
                    break;
            }
            ViewData["result"] = calc.result;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
