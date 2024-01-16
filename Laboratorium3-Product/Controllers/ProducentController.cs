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
    private readonly ICountryService _countryService;

    public ProducentController(IProducentService producentService, ICountryService countryService)
    {
        _producentService = producentService;
        _countryService = countryService;

    }
        
    public IActionResult Index()
    {
        var producents = _producentService.FindAll();
        foreach (var producent in producents)
        {
            var country = _countryService.FindById(producent.CountryId);
            if(country is null)
                continue;
            producent.Country = country.Name;
        }
        return View(producents);
    }
    
    [HttpGet]
    public IActionResult Create()
    {
        return View(new Producent() { CountryList = CreateSelectItem() });
    }
        
    [HttpPost]
    public IActionResult Create(Producent producent)
    {
        Console.WriteLine(ModelState.IsValid);
        if (ModelState.IsValid) 
        {
            _producentService.Add(producent);
            return RedirectToAction("Index");
        }
        return View(producent); 
    }
    private List<SelectListItem> CreateSelectItem()
    {
        var items = _producentService.FindAllCountries()
            .Select(e => new SelectListItem()
            {
                Text = e.Name,
                Value = e.Id.ToString()
            }).ToList();
        items.Add(new SelectListItem() { Text = "Unknown", Value = "" });
        return items;
    }
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var producent = _producentService.FindById(id);
        if (producent is null) return NotFound();
        producent.CountryList = CreateSelectItem();
        return View(producent);    
    }

    [HttpPost]
    public IActionResult Edit(Producent model)
    {
        if (ModelState.IsValid)
        {
            _producentService.Update(model);
            return RedirectToAction("Index");
        }
        model.CountryList = CreateSelectItem();
        return View(model);
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
        var producent = _producentService.FindById(id);
        Console.WriteLine(_countryService.FindById(producent.CountryId).Name);
        producent.Country = _countryService.FindById(producent.CountryId).Name;
        return View(producent);
    }
    
}