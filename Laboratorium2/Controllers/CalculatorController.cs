using Microsoft.AspNetCore.Mvc;
using Laboratorium2.Models;

namespace Laboratorium2.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        public IActionResult Result(Calculator calculator)
        {
            if (!calculator.IsValid()) return View("Error");

            return View(calculator);
        }
    }
}
