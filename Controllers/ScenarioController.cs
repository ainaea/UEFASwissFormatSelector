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
                var similarScenario = repository.Scenarios.FirstOrDefault(s => s.NumberOfTeamsPerPot == scenario.NumberOfTeamsPerPot && s.NumberOfPot == scenario.NumberOfPot && s.NumberOfGamesPerPot == scenario.NumberOfGamesPerPot && s.HomeAndAwayPerOpponent == scenario.HomeAndAwayPerOpponent);
                if (similarScenario != null)
                {
                    ModelState.AddModelError("", "Similar scenario is already existing");
                    return View(scenario);
                }
                if (scenario.NumberOfTeamsPerPot <= scenario.NumberOfGamesPerPot || scenario.NumberOfTeamsPerPot * scenario.NumberOfGamesPerPot % 2 != 0)
                {
                    if (scenario.NumberOfTeamsPerPot <= scenario.NumberOfGamesPerPot)
                        ModelState.AddModelError("",$"It is impossible to get {scenario.NumberOfGamesPerPot} opponents from {scenario.NumberOfTeamsPerPot} teams in all pots");
                    if (scenario.NumberOfTeamsPerPot * scenario.NumberOfGamesPerPot % 2 != 0)
                        ModelState.AddModelError("", $"Can not create {(scenario.NumberOfGamesPerPot * scenario.NumberOfTeamsPerPot+1)/2} fixtures from {scenario.NumberOfGamesPerPot * scenario.NumberOfTeamsPerPot} team slots");
                    return View(scenario);
                }
                repository.Scenarios.Add(scenario);
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
                repository.Scenarios.Update(scenario);                
                return RedirectToAction(nameof(Index));
            }
            return View(scenario);
        }
    }
}
