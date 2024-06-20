using Microsoft.AspNetCore.Mvc;
using UEFASwissFormatSelector.Models;
using UEFASwissFormatSelector.ViewModels;

namespace UEFASwissFormatSelector.Controllers
{
    public class ScenarioInstanceController : Controller
    {
        private static List<ScenarioInstance> _scenarioInstances;
        public static List<ScenarioInstance> Scenarios { get => _scenarioInstances ?? SetupScenarios(); }
        public ScenarioInstanceController()
        {
            if (_scenarioInstances == null)
                SetupScenarios();
        }
        private static List<ScenarioInstance> SetupScenarios()
        {
            //var UEFA2425 = ScenarioController.Scenarios.FirstOrDefault(s => s.Id == new Guid("c5300dfa-f995-4bb3-9e2e-009b85752995"));
            //var EPL = ScenarioController.Scenarios.FirstOrDefault(s => s.Id == new Guid("d5300dfa-f995-4bb3-9e2e-009b85752995"));

            _scenarioInstances = new List<ScenarioInstance>();
            //if (UEFA2425 != null)
            //    _scenarioInstances.Add()
            //{
            //    new ScenarioInstance{ Name = "UEFA2425", ScenarioId = new Guid("c5300dfa-f995-4bb3-9e2e-009b85752995")},
            //    new ScenarioInstance{ Name = "EPL", ScenarioId = new Guid("d5300dfa-f995-4bb3-9e2e-009b85752995")}
            //};
            return _scenarioInstances;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_scenarioInstances);
        }
        [HttpGet]
        public IActionResult Add(Guid scenarioId)
        {
            var scenario = ScenarioController.Scenarios.FirstOrDefault(s => s.Id == scenarioId);
            if (scenario == null)
                return RedirectToAction(nameof(Index), nameof(Scenario));
            var viewModel = new AddScenarioInstanceViewModel();
            viewModel.Scenario = scenario;
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Add(AddScenarioInstanceViewModel instanceVM)
        {
            if (ModelState.IsValid)
            {
                var scenario = ScenarioController.Scenarios.FirstOrDefault(s => s.Id == instanceVM.Scenario.Id);
                if (scenario == null)
                    return RedirectToAction(nameof(Index), nameof(Scenario));
                var instance = new ScenarioInstance(scenario)
                {
                    Name = instanceVM.Name
                };
                _scenarioInstances.Add(instance);
                return RedirectToAction(nameof(Index));
            }
            return View(instanceVM);
        }
        [HttpGet]
        public IActionResult Edit(Guid scenarioInstanceId)
        {
            var scenarioInstance = _scenarioInstances.FirstOrDefault(s => s.Id == scenarioInstanceId);
            if (scenarioInstance == null)
                return RedirectToAction(nameof(Index));
            var viewModel = new EditScenarioInstanceViewModel
            {
                InstanceId = scenarioInstance.Id,
                Scenario = scenarioInstance.Scenario,
                Name = scenarioInstance.Name
            };
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Edit(EditScenarioInstanceViewModel instanceVM)
        {
            if (ModelState.IsValid)
            {
                var scenarioInstance = _scenarioInstances.FirstOrDefault(s => s.Id == instanceVM.InstanceId);
                if (scenarioInstance != null)
                    scenarioInstance.Name = instanceVM.Name;
                return RedirectToAction(nameof(Index));
            }
            return View(instanceVM);
        }
        [HttpGet]
        public IActionResult Explore(Guid scenarioInstanceId)
        {
            var scenarioInstance = _scenarioInstances.FirstOrDefault(s => s.Id == scenarioInstanceId);
            if (scenarioInstance == null)
                return RedirectToAction(nameof(Index));
            var viewModel = new ExploreScenarioInstanceViewModel
            {
                Id = scenarioInstance.Id,
                Scenario = scenarioInstance.Scenario,
                Name = scenarioInstance.Name,
                ClubsInScenarioInstance = scenarioInstance.ClubsInScenarioInstance
            };
            if (!viewModel.ClubsInScenarioInstance.Any( c=>c == null))
                foreach (var club in viewModel.ClubsInScenarioInstance)
                {
                    club.Club = ClubController.Clubs.FirstOrDefault(c => c.Id == club.ClubId);
                }
            return View(viewModel);
        }
        [HttpGet]
        public IActionResult AddClubs(Guid scenarioInstanceId)
        {
            var scenarioInstance = _scenarioInstances.FirstOrDefault(s => s.Id == scenarioInstanceId);
            if (scenarioInstance == null)
                return RedirectToAction(nameof(Index));
            var viewModel = new List<SelectViewModel>();
            foreach (Club club in ClubController.Clubs)
            {
                viewModel.Add(new SelectViewModel
                {
                    Id = club.Id,
                    Name = club.Name
                });
            }
            ViewBag.scenarioInstanceId = scenarioInstanceId;
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult AddClubs(List<SelectViewModel> selections, Guid scenarioInstanceId)
        {
            if (ModelState.IsValid)
            {
                var scenarioInstance = _scenarioInstances.FirstOrDefault(s => s.Id == scenarioInstanceId);
                if (scenarioInstance == null)
                    return RedirectToAction(nameof(Index));
                var checkedSelections = selections.Where(s => s.IsSelected).ToList();
                int expectedSelections = scenarioInstance.Scenario.NumberOfPot * scenarioInstance.Scenario.NumberOfTeamsPerPot;
                int actualSelections = checkedSelections.Count();
                if (actualSelections != expectedSelections)
                {
                    ViewBag.scenarioInstanceId = scenarioInstanceId;
                    ModelState.AddModelError(string.Empty, $"You have selected {actualSelections} instead of {expectedSelections}");
                    return View(selections);
                }
                var clubsInInstance = new List<ClubInScenarioInstance>();
                foreach (var item in checkedSelections)
                {
                    clubsInInstance.Add( new ClubInScenarioInstance(item.Id, scenarioInstanceId)
                    {
                        Club = ClubController.Clubs.FirstOrDefault(c=> c.Id == item.Id)
                    });
                }
                scenarioInstance.ClubsInScenarioInstance = clubsInInstance;
                return RedirectToAction(nameof(Explore), new { scenarioInstanceId = scenarioInstanceId });
            }
            return View(selections);
        }
    }
}
