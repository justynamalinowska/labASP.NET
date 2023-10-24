using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Laboratorium3_Product.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Laboratorium3_Product.Controllers
{
    public class ProductController : Controller
    {
        static readonly Dictionary<int, Product> _products = new Dictionary<int, Product>();

        static int Id = 1;
        public IActionResult Index()
        {
            return View(_products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            if (ModelState.IsValid)
            {
                model.Id++;
                _products.Add(model.Id, model);
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
            return View(_products[id]);
        }

        [HttpPost]
        public IActionResult Update(Product model)
        {
            if (ModelState.IsValid)
            {
                _products[model.Id] = model;
                return RedirectToAction("Index");
            }
            //return View();
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_products[id]);
        }

        [HttpPost]
        public IActionResult Delete(Product model)
        {
            _products.Remove(model.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_products[id]);
        }
    }
}

