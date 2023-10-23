using Microsoft.AspNetCore.Mvc;
using Laboratorium2.Models;

namespace Laboratorium2.Controllers
{
    public class BirthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        public IActionResult Result(Birth birth)
        {
            if (!birth.IsValid()) return View("Error");

            return View(birth);
        }
    }
}
