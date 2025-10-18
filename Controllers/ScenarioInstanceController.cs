using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UEFASwissFormatSelector.Models;
using UEFASwissFormatSelector.Services;
using UEFASwissFormatSelector.ViewModels;

namespace UEFASwissFormatSelector.Controllers
{
    public class ScenarioInstanceController : Controller
    {
        private readonly IRepository repository;
        private readonly IMatchDrawService matchDrawService;

        public ScenarioInstanceController(IRepository repository, IMatchDrawService matchDrawService)
        {
            this.repository = repository;
            this.matchDrawService = matchDrawService;
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
                //var ss = new Dictionary<int, string>();
                //ss.Add(0, instance.Name);
                //ss.Add(1, "hello");
                //return Ok(ss);
                //return Ok(instance);
                repository.ScenarioInstances.Add(instance);
                return RedirectToAction(nameof(Index));
            }
            return View(instanceVM);
        }
        [HttpGet]
        public IActionResult Edit(Guid scenarioInstanceId)
        {
            var scenarioInstance = repository.ScenarioInstances.Find(scenarioInstanceId);
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
                var scenarioInstance = repository.ScenarioInstances.Find(instanceVM.InstanceId);
                if (scenarioInstance != null)
                {
                    scenarioInstance.Name = instanceVM.Name;
                    repository.ScenarioInstances.Update(scenarioInstance);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(instanceVM);
        }
        [HttpGet]
        //public IActionResult Explore(Guid scenarioInstanceId, ExploreScenarioInstanceViewModel? vm = null)
        //{
        //    var scenarioInstance = repository.ScenarioInstances.FirstOrDefault(s => s.Id == scenarioInstanceId);
        //    if (scenarioInstance == null)
        //        return RedirectToAction(nameof(Index));
        //    ExploreScenarioInstanceViewModel viewModel;
        //    if (vm == null)
        //    {
        //        viewModel = GenerateVM(scenarioInstance);
        //    }
        //    else
        //    {
        //        viewModel = vm as ExploreScenarioInstanceViewModel;
        //    }

        //    return View(viewModel);
        //}
        public IActionResult Explore(Guid scenarioInstanceId)
        {
            var scenarioInstance = repository.ScenarioInstances.Find(scenarioInstanceId);
            if (scenarioInstance == null)
                return RedirectToAction(nameof(Index));
            scenarioInstance.Pots ??= new Pot[scenarioInstance.Scenario.NumberOfPot];
            scenarioInstance.ClubsInScenarioInstance ??= new ClubInScenarioInstance[scenarioInstance.Scenario.NumberOfPot * scenarioInstance.Scenario.NumberOfTeamsPerPot];
            var viewModel = new ExploreScenarioInstanceViewModel
            {
                Id = scenarioInstance.Id,
                Scenario = scenarioInstance.Scenario,
                Name = scenarioInstance.Name,
                ClubsInScenarioInstance = scenarioInstance.ClubsInScenarioInstance,
                Pots = scenarioInstance.Pots,
                Opponents = scenarioInstance.Opponents,
                MatchUps = scenarioInstance.MatchUps,
                MatchUpSkeleton = scenarioInstance.MatchUpSkeleton
            };
            if (!viewModel.ClubsInScenarioInstance.Any(c => c == null))
                foreach (var club in viewModel.ClubsInScenarioInstance)
                {
                    club.Club = repository.Clubs.FirstOrDefault(c => c.Id == club.ClubId);
                }
            return View(viewModel);
        }

        //private ExploreScenarioInstanceViewModel GenerateVM(ScenarioInstance scenarioInstance)
        //{
        //    ExploreScenarioInstanceViewModel viewModel = new ExploreScenarioInstanceViewModel
        //    {
        //        Id = scenarioInstance.Id,
        //        Scenario = scenarioInstance.Scenario,
        //        Name = scenarioInstance.Name,
        //        ClubsInScenarioInstance = scenarioInstance.ClubsInScenarioInstance,
        //        Pots = scenarioInstance.Pots
        //    };
        //    if (!viewModel.ClubsInScenarioInstance.Any(c => c == null))
        //        foreach (var club in viewModel.ClubsInScenarioInstance)
        //        {
        //            club.Club = repository.Clubs.FirstOrDefault(c => c.Id == club.ClubId);
        //        }

        //    return viewModel;
        //}

        [HttpGet]
        public IActionResult AddClubs(Guid scenarioInstanceId)
        {
            var scenarioInstance = repository.ScenarioInstances.Find(scenarioInstanceId);
            if (scenarioInstance == null)
                return RedirectToAction(nameof(Index));
            var viewModel = new List<SelectViewModel>();
            foreach (Club club in repository.Clubs.OrderBy(c => c.Name))
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
                var scenarioInstance = repository.ScenarioInstances.Find(scenarioInstanceId);
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
                repository.ScenarioInstances.Update(scenarioInstance);
                return RedirectToAction(nameof(Explore), new { scenarioInstanceId = scenarioInstanceId });
            }
            return View(selections);
        }
        [HttpGet]
        public IActionResult RankClubs(Guid scenarioInstanceId)
        {
            var scenarioInstance = repository.ScenarioInstances.Find(scenarioInstanceId);
            if (scenarioInstance == null)
                return RedirectToAction(nameof(Index));
            ViewBag.scenarioInstanceId = scenarioInstanceId;
            var viewModel = scenarioInstance.ClubsInScenarioInstance.OrderByDescending(c => c.Ranking).ToList();
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult RankClubs(IEnumerable<ClubInScenarioInstance> model, Guid scenarioInstanceId)
        {
            if (ModelState.IsValid)
            {
                var scenarioInstance = repository.ScenarioInstances.Find(scenarioInstanceId);
                if (scenarioInstance == null)
                    return RedirectToAction(nameof(Index));
                if (repository is MockRepository)
                {
                    scenarioInstance.ClubsInScenarioInstance = model;                    
                }
                else
                {    
                    foreach (var cisi in model)
                    {
                        scenarioInstance.ClubsInScenarioInstance.First(c => c.ClubId == cisi.ClubId).Ranking = cisi.Ranking;
                    }
                    repository.ScenarioInstances.Update(scenarioInstance);
                }
                    return RedirectToAction(nameof(Explore), new { scenarioInstanceId = scenarioInstanceId });
            }
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult PotClubs(IEnumerable<ClubInScenarioInstance> model, Guid scenarioInstanceId)
        {
            var scenarioInstance = repository.ScenarioInstances.Find(scenarioInstanceId);
            if (scenarioInstance == null)
                return RedirectToAction(nameof(Index));
            var pottings = matchDrawService.PotTeam(scenarioInstance);
            if (repository is MockRepository)
                scenarioInstance.Pots = pottings;
            else
            {
                var sqlrepo = repository as SqlRepository;
                sqlrepo.Add<Pot>(pottings.ToList());
            }
            return RedirectToAction(nameof(Explore), new { scenarioInstanceId = scenarioInstanceId });
        }
        [HttpGet]
        public IActionResult GenerateOponents(Guid scenarioInstanceId)
        {
            var scenarioInstance = repository.ScenarioInstances.Find(scenarioInstanceId);
            if (scenarioInstance == null)
                return RedirectToAction(nameof(Index));
            var opponnentsDictionary = matchDrawService.GenerateOpponentsForAllClubs(scenarioInstance);
            //var viewModel = GenerateVM(scenarioInstance);
            scenarioInstance.Opponents ??= new ModifiedDictionary<IEnumerable<Pot>>();
            scenarioInstance.Opponents.RePopulate(opponnentsDictionary);
            if (!(repository is MockRepository))
            {
                var sqlrepo = repository as SqlRepository;
                sqlrepo.Add<ModifiedDictionary<IEnumerable<Pot>>>(new List<ModifiedDictionary<IEnumerable<Pot>>> { scenarioInstance.Opponents });
                sqlrepo.ScenarioInstances.Update(scenarioInstance);
                //sqlrepo.Add<Pot>(scenarioInstance.Opponents.GetAllValues<Pot>());
                sqlrepo.Add<DbModifiedDictionaryEntity<Pot>>(scenarioInstance.Opponents.GetEquivalentDbEntities<Pot>());

                var matchUpResult = matchDrawService.DoMatchUps(scenarioInstance, scenarioInstance.Scenario.NumberOfGamesPerPot);
                var ee =new ModifiedDictionary<List<Club>>() { Id = Guid.NewGuid(), ScenarioInstanceId = scenarioInstanceId};
                //scenarioInstance.MatchUpSkeleton ??= new ModifiedDictionary<List<string>>();
                ee.RePopulate(matchUpResult.Item1);
                //scenarioInstance.MatchUps = ee;
                //scenarioInstance.MatchUpSkeleton.RePopulate(matchUpResult.Item2);
                sqlrepo.Add<DbModifiedDictionaryEntity<Club>>(ee.GetEquivalentDbEntities<Club>());
                sqlrepo.Add<Pot>(scenarioInstance.Opponents.GetAllValues<Pot>());
            }    
            return RedirectToAction(nameof(Explore), new { scenarioInstanceId = scenarioInstanceId});
        }
        [HttpGet]
        public IActionResult ShowMatchUp(Guid scenarioInstanceId)
        {
            var scenarioInstance = repository.ScenarioInstances.Find(scenarioInstanceId);
            if (scenarioInstance == null)
                return RedirectToAction(nameof(Index));
            var matchUpResult = matchDrawService.DoMatchUps(scenarioInstance, scenarioInstance.Scenario.NumberOfGamesPerPot);
            scenarioInstance.MatchUps ??=new ModifiedDictionary<List<Club>>();
            scenarioInstance.MatchUpSkeleton ??= new ModifiedDictionary<List<string>>();
            scenarioInstance.MatchUps.RePopulate(matchUpResult.Item1);
            scenarioInstance.MatchUpSkeleton.RePopulate(matchUpResult.Item2);
            if (!(repository is MockRepository))
            {
                var sqlrepo = repository as SqlRepository;
                scenarioInstance.MatchUps = scenarioInstance.MatchUps;
                scenarioInstance.Pots = sqlrepo.Pots.Where(p => p.ScenarioInstanceId == scenarioInstanceId);
                //sqlrepo.Add<ModifiedDictionary<List<Club>>>(new List<ModifiedDictionary<List<Club>>> { scenarioInstance.MatchUps });
                //sqlrepo.ScenarioInstances.Update(scenarioInstance);
                ////sqlrepo.Add< DbModifiedDictionaryEntity<Club>(scenarioInstance.MatchUps.GetAllValues<Club>());
                sqlrepo.Add<DbModifiedDictionaryEntity<Club>>(scenarioInstance.MatchUps.GetEquivalentDbEntities<Club>());
            }
            return RedirectToAction(nameof(Explore), new { scenarioInstanceId = scenarioInstanceId });
        }
    }
}
