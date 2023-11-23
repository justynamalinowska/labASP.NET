using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Data;
using Data.Entities;
using System.Collections.Generic;
using Laboratorium3.Models;

namespace Laboratorium3.Controllers
{
    public class OrganizationController : Controller
    {
        private readonly IOrganizationService _organizationService;

        public OrganizationController(IOrganizationService organizationService)
        {
            _organizationService = organizationService;
        }
        
        public IActionResult Index()
        {
            var organizations = _organizationService.FindAll();
            return View(organizations);
        }
        
        
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Organization());
        }
        
        [HttpPost]
        public IActionResult Create(Organization organization)
        {
            if (ModelState.IsValid) 
            {
                _organizationService.Add(organization);
                return RedirectToAction("Index");
            }
            return View(organization); 
        }
        
        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_organizationService.FindById(id));    
        }

        [HttpPost]
        public IActionResult Edit(Organization model)
        {
            if (ModelState.IsValid)
            {
                _organizationService.Update(model);
                return RedirectToAction("Index");
            }

            return View();
        }
        
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_organizationService.FindById(id));
        }

        [HttpPost]
        public IActionResult Delete(Organization model)
        {
            _organizationService.Delete(model.Id);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_organizationService.FindById(id));
        }
        
    }
}