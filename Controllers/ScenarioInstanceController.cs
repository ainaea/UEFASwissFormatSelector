using Microsoft.AspNetCore.Mvc;
using UEFASwissFormatSelector.Models;
using UEFASwissFormatSelector.Services;
using UEFASwissFormatSelector.ViewModels;

namespace UEFASwissFormatSelector.Controllers
{
    public class ScenarioInstanceController : Controller
    {
        private readonly IRepository repository;

        public ScenarioInstanceController(IRepository repository)
        {
            this.repository = repository;
        }        
        [HttpGet]
        public IActionResult Index()
        {
            return View(repository.ScenarioInstances);
        }
        [HttpGet]
        public IActionResult Add(Guid scenarioId)
        {
            var scenario = repository.Scenarios.FirstOrDefault(s => s.Id == scenarioId);
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
                var scenario = repository.Scenarios.FirstOrDefault(s => s.Id == instanceVM.Scenario.Id);
                if (scenario == null)
                    return RedirectToAction(nameof(Index), nameof(Scenario));
                var instance = new ScenarioInstance(scenario)
                {
                    Name = instanceVM.Name
                };
                (repository.ScenarioInstances as List<ScenarioInstance>)?.Add(instance);
                return RedirectToAction(nameof(Index));
            }
            return View(instanceVM);
        }
        [HttpGet]
        public IActionResult Edit(Guid scenarioInstanceId)
        {
            var scenarioInstance = repository.ScenarioInstances.FirstOrDefault(s => s.Id == scenarioInstanceId);
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
                var scenarioInstance = repository.ScenarioInstances.FirstOrDefault(s => s.Id == instanceVM.InstanceId);
                if (scenarioInstance != null)
                    scenarioInstance.Name = instanceVM.Name;
                return RedirectToAction(nameof(Index));
            }
            return View(instanceVM);
        }
        [HttpGet]
        public IActionResult Explore(Guid scenarioInstanceId)
        {
            var scenarioInstance = repository.ScenarioInstances.FirstOrDefault(s => s.Id == scenarioInstanceId);
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
                    club.Club = repository.Clubs.FirstOrDefault(c => c.Id == club.ClubId);
                }
            return View(viewModel);
        }
        [HttpGet]
        public IActionResult AddClubs(Guid scenarioInstanceId)
        {
            var scenarioInstance = repository.ScenarioInstances.FirstOrDefault(s => s.Id == scenarioInstanceId);
            if (scenarioInstance == null)
                return RedirectToAction(nameof(Index));
            var viewModel = new List<SelectViewModel>();
            foreach (Club club in repository.Clubs)
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
                var scenarioInstance = repository.ScenarioInstances.FirstOrDefault(s => s.Id == scenarioInstanceId);
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
                        Club = repository.Clubs.FirstOrDefault(c=> c.Id == item.Id)
                    });
                }
                scenarioInstance.ClubsInScenarioInstance = clubsInInstance;
                return RedirectToAction(nameof(Explore), new { scenarioInstanceId = scenarioInstanceId });
            }
            return View(selections);
        }
    }
}
