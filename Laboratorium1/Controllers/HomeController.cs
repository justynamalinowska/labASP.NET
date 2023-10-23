using Laboratorium1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Laboratorium1.Controllers
{
    public enum Operator
    {
        Add, Mul, Sub, Div
    }

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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About(string author)
        {
            ViewBag.Author = author;
            return View();
        }

        public IActionResult Calculator([FromQuery(Name = "operator")]Operator? op, double? x, double? y)
        {
            if (x is null || y is null || op is null) return View("Error");

            switch (op)
            {
                case Operator.Add:
                    ViewBag.Result = x + y;
                    break;
                case Operator.Sub:
                    ViewBag.Result = x - y;
                    break;
                case Operator.Mul:
                    ViewBag.Result = x * y;
                    break;
                case Operator.Div:
                    ViewBag.Result = x / y;
                    break;
            }

            ViewBag.Op = op;
            ViewBag.X = x;
            ViewBag.Y = y;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}