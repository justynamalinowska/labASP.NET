using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Laboratorium3_Product.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection.Metadata.Ecma335;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Laboratorium3_Product.Controllers
{
    [Authorize(Roles = "admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [AllowAnonymous]
        public IActionResult Index(int page = 1, int size = 2)
        {
            ViewBag.PageSize = size;
            return View(_productService.FindPage(page, size));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Product() { ProducentList = CreateSelectItem() });
        }
        
        private List<SelectListItem> CreateSelectItem()
        {
            var items = _productService.FindAllProducents()
                .Select(e => new SelectListItem()
                {
                    Text = e.Name,
                    Value = e.Id.ToString()
                }).ToList();
            items.Add(new SelectListItem() { Text = "Unknown", Value = "" });
            return items;
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
                return View(model); 
            }
        }
        
        public IActionResult CreateApi()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateApi(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var product = _productService.FindById(id);
            if (product is null) return NotFound();
            product.ProducentList = CreateSelectItem();
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product model)
        {
            if (ModelState.IsValid)
            {
                if (model.ProducentId != 0)
                {
                    _productService.Update(model);
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(nameof(model.ProducentId), "Proszę wybrać producenta.");
                }
            }
            model.ProducentList = CreateSelectItem();
            return View(model);
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
            var model = _productService.FindById(id);
            if (model is null)
            {
                return NotFound();
            }
            return View(model);
        }
    }
}
