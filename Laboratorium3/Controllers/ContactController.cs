using Laboratorium3.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Laboratorium3.Controllers
{
    [Authorize]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            return View(_contactService.FindAll());
        }

        public IActionResult PagedIndex(int page = 1, int size = 2 )
        {
            ViewBag.PageSize = size;
            return View(_contactService.FindPage(page, size));
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Contact() { OrganizationList = CreateSelectItem() });
        }

        private List<SelectListItem> CreateSelectItem()
        {
            var items = _contactService.FindAllOrganizations()
                          .Select(e => new SelectListItem()
                          {
                              Text = e.Name,
                              Value = e.Id.ToString()
                          }).ToList();
            items.Add(new SelectListItem() { Text = "Unknown", Value = "" });
            return items;
        }

        [HttpPost]
        public IActionResult Create(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Add(model);
                return RedirectToAction("Index");
            }
            model.OrganizationList = CreateSelectItem();
            return View(model);
        }

        public IActionResult CreateApi()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateApi(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Add(model);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        
        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_contactService.FindById(id));
        }

        [HttpPost]
        public IActionResult Update(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Update(model);
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
            return View(_contactService.FindById(id));
        }

        [HttpPost]
        public IActionResult Delete(Contact model)
        {
            _contactService.Delete(model.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_contactService.FindById(id));
        }
    }
}



   

