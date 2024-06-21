using Microsoft.AspNetCore.Mvc;
using UEFASwissFormatSelector.Models;
using UEFASwissFormatSelector.Services;
using UEFASwissFormatSelector.ViewModels;

namespace UEFASwissFormatSelector.Controllers
{
    public class ScenarioController : Controller
    {
        private readonly IRepository repository;

        public ScenarioController(IRepository repository)
        {
            this.repository = repository;
        }
        
        public IActionResult Index()
        {
            return View(repository.Scenarios);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Scenario scenario)
        {
            if (ModelState.IsValid)
            {
                var similarScenario = repository.Scenarios.FirstOrDefault(s => s.NumberOfTeamsPerPot == scenario.NumberOfTeamsPerPot && s.NumberOfTeamsPerPot == scenario.NumberOfTeamsPerPot && s.NumberOfGamesPerPot == scenario.NumberOfGamesPerPot && s.HomeAndAwayPerOpponent == scenario.HomeAndAwayPerOpponent );
                if (similarScenario != null)
                {
                    ModelState.AddModelError("", "Similar scenario is already existing");
                    return View(scenario);
                }
                (repository.Scenarios as List<Scenario>)?.Add(scenario);
                return RedirectToAction(nameof(Index));
            }
            return View(scenario);
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var scenario = repository.Scenarios.ToList().Find(c => c.Id == id);
            if (scenario == null)
                RedirectToAction(nameof(Index));
            return View(scenario);
        }
        [HttpPost]
        public IActionResult Edit(Scenario scenario)
        {
            if (ModelState.IsValid)
            {
                var dbScenario = repository.Scenarios.FirstOrDefault(c => c.Id == scenario.Id);
                if (dbScenario != null)
                    dbScenario.Name = scenario.Name;
                return RedirectToAction(nameof(Index));
            }
            return View(scenario);
        }
    }
}
