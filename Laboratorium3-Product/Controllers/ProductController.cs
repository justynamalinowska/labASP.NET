using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Laboratorium3_Product.Models;
using Laboratorium3.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Laboratorium3_Product.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View(_productService.FindAll());
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
                _productService.Add(model);
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
            return View(_productService.FindById(id));
        }

        [HttpPost]
        public IActionResult Update(Product model)
        {
            if (ModelState.IsValid)
            {
                _productService.Update(model);
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_productService.FindById(id));
        }

        [HttpPost]
        public IActionResult Delete(Product model)
        {
            _productService.Delete(model.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_productService.FindById(id));
        }
    }
}

