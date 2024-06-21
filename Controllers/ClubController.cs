using Microsoft.AspNetCore.Mvc;
using UEFASwissFormatSelector.Models;
using UEFASwissFormatSelector.Services;

namespace UEFASwissFormatSelector.Controllers
{
    public class ClubController : Controller
    {
        private IRepository _repository;
        public ClubController(IRepository repository)
        {
            _repository = repository;
        }        
        [HttpGet]
        public IActionResult Index()
        {            
            return View(_repository.Clubs);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Countries = _repository.Countries;
            return View();
        }
        [HttpPost]
        public IActionResult Add(Club club)
        {
            if (ModelState.IsValid)
            {
                (_repository.Clubs as List<Club>)?.Add(club);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Countries = _repository.Countries;
            return View(club);
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var club = _repository.Clubs.ToList().Find(c => c.Id == id);
            if (club == null)
            {
                RedirectToAction(nameof(Index));
            }
            ViewBag.Countries = _repository.Countries;
            return View(club);
        }
        [HttpPost]
        public IActionResult Edit(Club club)
        {
            if (ModelState.IsValid)
            {
                var dbCLub = _repository.Clubs.FirstOrDefault(c => c.Id == club.Id);
                if (dbCLub != null)
                    (_repository.Clubs as List<Club>)![_repository.Clubs.ToList().IndexOf(dbCLub)] = club;
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Countries = _repository.Scenarios;
            return View(club);
        }
    }
}
