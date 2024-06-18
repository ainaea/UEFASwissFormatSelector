using Microsoft.AspNetCore.Mvc;
using UEFASwissFormatSelector.Models;

namespace UEFASwissFormatSelector.Controllers
{
    public class ClubController : Controller
    {
        private static List<Club> _clubs;
        public ClubController()
        {
            if (_clubs == null)
                _clubs = new List<Club>
            {
                new Club{ Name = "Manchester City", CountryId = new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995")},
                new Club{ Name = "Real Madrid", CountryId = new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06")},
                new Club{ Name = "Bayern Munich", CountryId = new Guid("6321ef33-73b5-45f8-9927-9afb37f39844")},
                new Club{ Name = "Inter Milan", CountryId = new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3")},
            };
        }
        [HttpGet]
        public IActionResult Index()
        {
            foreach (Club club in _clubs?.Where( cb=> cb.Country == null && cb.CountryId != Guid.Empty))
            {
                club.Country = CountryController.Countries.FirstOrDefault(c => c.Id == club.CountryId);
            }
            return View(_clubs);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Countries = CountryController.Countries;
            return View();
        }
        [HttpPost]
        public IActionResult Add(Club club)
        {
            if (ModelState.IsValid)
            {
                _clubs.Add(club);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Countries = CountryController.Countries;
            return View(club);
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var club = _clubs.Find(c => c.Id == id);
            if (club == null)
            {
                RedirectToAction(nameof(Index));
            }
            ViewBag.Countries = CountryController.Countries;
            return View(club);
        }
        [HttpPost]
        public IActionResult Edit(Club club)
        {
            if (ModelState.IsValid)
            {
                var dbCLub = _clubs.FirstOrDefault(c => c.Id == club.Id);
                if (dbCLub != null)
                    _clubs[_clubs.IndexOf(dbCLub)] = club;
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Countries = CountryController.Countries;
            return View(club);
        }
    }
}
