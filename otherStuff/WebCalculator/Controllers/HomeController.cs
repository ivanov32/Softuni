using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebCalculator.Models;

namespace WebCalculator.Controllers
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
        public IActionResult Index(Calculator cal)
        {
            double a, b;
            a = cal.value1;
            b = cal.value2;
            if (cal.calculate == "-")
            {
                cal.result = a - b;
            }
            else if (cal.calculate == "+")
            {
                cal.result = a + b;
            }
            else if (cal.calculate == "*")
            {
                cal.result = a * b;
            }
            else if (cal.calculate == "/")
            {
                cal.result = a / b;
            }
            ViewData["result"] = cal.result;
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult calculator()
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
