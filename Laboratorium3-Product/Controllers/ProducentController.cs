using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Data;
using Data.Entities;
using Data.Migrations;
using Laboratorium3_Product.Models;
using Producent = Laboratorium3_Product.Models.Producent;

namespace Laboratorium3_Product.Controllers;

public class ProducentController : Controller
{
    private readonly IProducentService _producentService;

    public ProducentController(IProducentService producentService)
    {
        _producentService = producentService;
    }
        
    public IActionResult Index()
    {
        var producents = _producentService.FindAll();
        return View(producents);
    }
    
    [HttpGet]
    public IActionResult Create()
    {
        return View(new Producent());
    }
        
    [HttpPost]
    public IActionResult Create(Producent producent)
    {
        if (ModelState.IsValid) 
        {
            _producentService.Add(producent);
            return RedirectToAction("Index");
        }
        return View(producent); 
    }
    
    [HttpGet]
    public IActionResult Edit(int id)
    {
        return View(_producentService.FindById(id));    
    }

    [HttpPost]
    public IActionResult Edit(Producent model)
    {
        if (ModelState.IsValid)
        {
            _producentService.Update(model);
            return RedirectToAction("Index");
        }

        return View();
    }
    
    [HttpGet]
    public IActionResult Delete(int id)
    {
        return View(_producentService.FindById(id));
    }

    [HttpPost]
    public IActionResult Delete(Producent model)
    {
        _producentService.Delete(model.Id);
        return RedirectToAction("Index");
    }
        
    [HttpGet]
    public IActionResult Details(int id)
    {
        return View(_producentService.FindById(id));
    }
    
}