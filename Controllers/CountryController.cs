using Microsoft.AspNetCore.Mvc;
using UEFASwissFormatSelector.Models;
using UEFASwissFormatSelector.Services;

namespace UEFASwissFormatSelector.Controllers
{
    public class CountryController : Controller
    {
        private readonly IRepository repository;

        public CountryController(IRepository repository)
        {
            this.repository = repository;
        }        
        [HttpGet]
        public IActionResult Index()
        {            
            return View(repository.Countries.OrderBy(c => c.Name));
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Country country)
        {
            if(ModelState.IsValid)
            {
                repository.Countries.Add(country);
                return RedirectToAction(nameof(Index));
            }
            return View(country);
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var country = repository.Countries.ToList().Find(c => c.Id == id);
            if (country == null)
                RedirectToAction(nameof(Index));
            return View(country);
        }
        [HttpPost]
        public IActionResult Edit(Country country)
        {
            if (ModelState.IsValid)
            {
                repository.Countries.Update(country);
                return RedirectToAction(nameof(Index));
            }
            return View(country);
        }
    }
}
