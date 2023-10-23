using Laboratorium3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium3.Controllers
{
    public class ContactController : Controller
    {
        static readonly Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>();

        static int Id = 1;
        public IActionResult Index()
        {
            return View(_contacts);
        }

        [HttpGet]
        public IActionResult Create() 
        {
            return View();        
        }

        [HttpPost]
        public IActionResult Create(Contact model) 
        { 
            if (ModelState.IsValid) 
            {
                model.Id = Id++;
                _contacts.Add(model.Id, model);
                return RedirectToAction("Index");    
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_contacts[id]);
        }

        [HttpPost]
        public IActionResult Update(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contacts[model.Id] = model;
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_contacts[id]);
        }

        [HttpPost]
        public IActionResult Delete(Contact model)
        {
           _contacts.Remove(model.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_contacts[id]);
        }

    }
}
