using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Laboratorium3_Product.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection.Metadata.Ecma335;
using Data.Entities;

namespace Laboratorium3_Product.Controllers
{
    [Authorize]
    public class CountryController : Controller
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        public IActionResult Index()
        {
            return View(_countryService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Country model)
        {
            if (ModelState.IsValid)
            {
                _countryService.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        
        [HttpGet]
        public IActionResult Update(int id)
        {
            var country = _countryService.FindById(id);
            if (country is null) return NotFound();
            return View(country);
        }

        [HttpPost]
        public IActionResult Update(Country model)
        {
            if (ModelState.IsValid)
            {
                _countryService.Update(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_countryService.FindById(id));
        }

        [HttpPost]
        public IActionResult Delete(Country model)
        {
            _countryService.Delete(model.Id);
            return RedirectToAction("Index");
        }
    }
}
