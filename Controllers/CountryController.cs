using Microsoft.AspNetCore.Mvc;
using UEFASwissFormatSelector.Models;

namespace UEFASwissFormatSelector.Controllers
{
    public class CountryController : Controller
    {
        private static List<Country> _countries;
        public static List<Country> Countries { get => _countries ?? SetupCountries(); }
        public CountryController()
        {
            if (_countries == null)
                SetupCountries();


        }

        private static List<Country> SetupCountries()
        {
            _countries = new List<Country>
            {
                new Country{ Name = "England", Abbrevation = "Eng", Id = new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995")},
                new Country{ Name = "Italy", Abbrevation = "Ita", Id = new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3")},
                new Country{ Name = "Spain", Abbrevation = "Esp", Id = new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06")},
                new Country{ Name = "Germany", Abbrevation = "Ger", Id = new Guid("6321ef33-73b5-45f8-9927-9afb37f39844")},
            };
            return _countries;
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
