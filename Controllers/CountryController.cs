using Microsoft.AspNetCore.Mvc;
using UEFASwissFormatSelector.Models;

namespace UEFASwissFormatSelector.Controllers
{
    public class CountryController : Controller
    {
        private static List<Country> _countries;
        public CountryController()
        {
            if (_countries==null)
                _countries = new List<Country>
            {
                new Country{ Name = "England", Abbrevation = "Eng"},
                new Country{ Name = "Italy", Abbrevation = "Ita"},
                new Country{ Name = "Spain", Abbrevation = "Esp"},
                new Country{ Name = "Germany", Abbrevation = "Ger"},
            };
        }
        [HttpGet]
        public IActionResult Index()
        {            
            return View(_countries);
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
                _countries.Add(country);
                return RedirectToAction(nameof(Index));
            }
            return View(country);
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var country = _countries.Find(c => c.Id == id);
            if (country == null)
                RedirectToAction(nameof(Index));
            return View(country);
        }
        [HttpPost]
        public IActionResult Edit(Country country)
        {
            if (ModelState.IsValid)
            {
                var dbCountry = _countries.FirstOrDefault( c=> c.Id == country.Id);
                if (dbCountry != null)
                    _countries[_countries.IndexOf(dbCountry)] = country;
                return RedirectToAction(nameof(Index));
            }
            return View(country);
        }
    }
}
