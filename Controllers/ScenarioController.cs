using Microsoft.AspNetCore.Mvc;
using UEFASwissFormatSelector.Models;
using UEFASwissFormatSelector.ViewModels;

namespace UEFASwissFormatSelector.Controllers
{
    public class ScenarioController : Controller
    {
        private static List<Scenario> _scenarios;
        public static List<Scenario> Scenarios { get => _scenarios ?? SetupScenarios(); }
        public ScenarioController()
        {
            if (_scenarios == null)
                SetupScenarios();
        }
        private static List<Scenario> SetupScenarios()
        {
            _scenarios = new List<Scenario>
            {
                new Scenario{ Name = "UEFA2425", Id = new Guid("c5300dfa-f995-4bb3-9e2e-009b85752995"), NumberOfPot = 4, NumberOfTeamsPerPot = 9, NumberOfGamesPerPot = 2},
                new Scenario{ Name = "EPL", Id = new Guid("d5300dfa-f995-4bb3-9e2e-009b85752995"), NumberOfPot = 1, NumberOfTeamsPerPot = 20, NumberOfGamesPerPot = 19, HomeAndAwayPerOpponent = true}
            };
            return _scenarios;
        }
        public IActionResult Index()
        {
            //var viewModel = new List<ScenarioWithInstanceViewModel>();
            //foreach (var scenario in _scenarios)
            //{
            //    viewModel.Add( new ScenarioWithInstanceViewModel
            //    {
            //        Scenario = scenario,
            //        //ScenarioInstances = 
            //    } );
            //}
            return View(_scenarios);
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
                var similarScenario = _scenarios.FirstOrDefault(s => s.NumberOfTeamsPerPot == scenario.NumberOfTeamsPerPot && s.NumberOfTeamsPerPot == scenario.NumberOfTeamsPerPot && s.NumberOfGamesPerPot == scenario.NumberOfGamesPerPot && s.HomeAndAwayPerOpponent == scenario.HomeAndAwayPerOpponent );
                if (similarScenario != null)
                {
                    ModelState.AddModelError("", "Similar scenario is already existing");
                    return View(scenario);
                }
                _scenarios.Add(scenario);
                return RedirectToAction(nameof(Index));
            }
            return View(scenario);
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var scenario = Scenarios.Find(c => c.Id == id);
            if (scenario == null)
                RedirectToAction(nameof(Index));
            return View(scenario);
        }
        [HttpPost]
        public IActionResult Edit(Scenario scenario)
        {
            if (ModelState.IsValid)
            {
                var dbScenario = _scenarios.FirstOrDefault(c => c.Id == scenario.Id);
                if (dbScenario != null)
                    dbScenario.Name = scenario.Name;
                    //_scenarios[_scenarios.IndexOf(dbScenario)] = scenario;
                return RedirectToAction(nameof(Index));
            }
            return View(scenario);
        }
    }
}
