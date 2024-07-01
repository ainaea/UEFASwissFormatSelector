using UEFASwissFormatSelector.Models;

namespace UEFASwissFormatSelector.Services
{
    public class MockRepository : IRepository
    {
        private IEnumerable<Club> _clubs;
        private IEnumerable<Country> _countries;
        private IEnumerable<Scenario> _scenarios;
        private IEnumerable<ScenarioInstance> _scenarioInstances;
        public IEnumerable<Club> Clubs
        {
            get
            {
                foreach (var club in _clubs)
                {
                    if (club.Country == null)
                    {
                        club.Country = Countries.FirstOrDefault(c => c.Id == club.CountryId);
                    }                    
                }
                return _clubs;
            }
            set => _clubs = value;
        }

        public IEnumerable<Country> Countries { get => _countries; set => _countries = value; }
        public IEnumerable<Scenario> Scenarios { get => _scenarios; set => _scenarios = value; }
        public IEnumerable<ScenarioInstance> ScenarioInstances { get => _scenarioInstances; set => _scenarioInstances = value; }
        public MockRepository()
        {
            _clubs = SetupClubs();
            _countries = SetupCountries();
            _scenarios = SetupScenarios();
            _scenarioInstances = SetupScenarioInstances();
        }
        private IEnumerable<Club> SetupClubs()
        {
            return new List<Club>
            {
                new Club{ Name = "Manchester City", CountryId = new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995")},
                new Club{ Name = "Liverpool", CountryId = new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995")},
                new Club{ Name = "Arsenal", CountryId = new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995")},
                new Club{ Name = "Manchester United", CountryId = new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995")},
                new Club{ Name = "Newcastle United", CountryId = new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995")},
                new Club{ Name = "West Ham United", CountryId = new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995")},
                new Club{ Name = "Real Madrid", CountryId = new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06")},
                new Club{ Name = "Barcelona", CountryId = new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06")},
                new Club{ Name = "Atlético Madrid", CountryId = new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06")},
                new Club{ Name = "Sevilla", CountryId = new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06")},
                new Club{ Name = "Villarreal", CountryId = new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06")},
                new Club{ Name = "Bayern Munich", CountryId = new Guid("6321ef33-73b5-45f8-9927-9afb37f39844")},
                new Club{ Name = "Borussia Dortmund", CountryId = new Guid("6321ef33-73b5-45f8-9927-9afb37f39844")},
                new Club{ Name = "Bayer Leverkusen", CountryId = new Guid("6321ef33-73b5-45f8-9927-9afb37f39844")},
                new Club{ Name = "RB Leipzig", CountryId = new Guid("6321ef33-73b5-45f8-9927-9afb37f39844")},
                new Club{ Name = "Inter Milan", CountryId = new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3")},
                new Club{ Name = "Juventus", CountryId = new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3")},
                new Club{ Name = "AC Milan", CountryId = new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3")},
                new Club{ Name = "Napoli", CountryId = new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3")},
                new Club{ Name = "Roma", CountryId = new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3")},
                new Club{ Name = "Lazio", CountryId = new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3")},
                new Club{ Name = "Olympique de Marseille", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844")},
                new Club{ Name = "Paris Saint-Germain", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844")},
                new Club{ Name = "Lyon", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844")},
                new Club{ Name = "Monaco", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844")},
                new Club{ Name = "Benfica", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39855")},
                new Club{ Name = "Porto", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39855")},
                new Club{ Name = "Sporting CP", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39855")},
                new Club{ Name = "Ajax", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39866")},
                new Club{ Name = "Feyenoord", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39866")},
                new Club{ Name = "Celtic", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39877")},
                new Club{ Name = "Shakhtar Donetsk", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39888")},
                new Club{ Name = "Galatasaray", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39899")},

                new Club{ Name = "Red Star Belgrade", CountryId = new Guid("1661ef33-73b5-45f8-9927-9bfb37f39866")},
                new Club{ Name = "Dinamo Zagreb", CountryId = new Guid("1661ef33-73b5-45f8-9927-9bfb37f39877")},
                new Club{ Name = "Olympiacos", CountryId = new Guid("1661ef33-73b5-45f8-9927-9bfb37f39888")},
                new Club{ Name = "Club Brugge", CountryId = new Guid("1661ef33-73b5-45f8-9927-9bfb37f39899")},
                new Club{ Name = "Copenhagen", CountryId = new Guid("2661ef33-73b5-45f8-9927-9bfb37f39899")},
            };
        }
        private IEnumerable<Country> SetupCountries()
        {
            return new List<Country>
            {
                new Country{ Name = "England", Abbrevation = "ENG", Id = new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995")},
                new Country{ Name = "Italy", Abbrevation = "ITA", Id = new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3")},
                new Country{ Name = "Spain", Abbrevation = "ESP", Id = new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06")},
                new Country{ Name = "Germany", Abbrevation = "GER", Id = new Guid("6321ef33-73b5-45f8-9927-9afb37f39844")},
                new Country{ Name = "France", Abbrevation = "FRA", Id = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844")},
                new Country{ Name = "Portugal", Abbrevation = "POR", Id = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39855")},
                new Country{ Name = "Netherlands", Abbrevation = "NED", Id = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39866")},
                new Country{ Name = "Scotland", Abbrevation = "SCO", Id = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39877")},
                new Country{ Name = "Ukraine", Abbrevation = "UKR", Id = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39888")},
                new Country{ Name = "Turkey", Abbrevation = "TUR", Id = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39899")},
                new Country{ Name = "Serbia", Abbrevation = "SRB", Id = new Guid("1661ef33-73b5-45f8-9927-9bfb37f39866")},
                new Country{ Name = "Croatia", Abbrevation = "CRO", Id = new Guid("1661ef33-73b5-45f8-9927-9bfb37f39877")},
                new Country{ Name = "Greece", Abbrevation = "GRE", Id = new Guid("1661ef33-73b5-45f8-9927-9bfb37f39888")},
                new Country{ Name = "Belgium", Abbrevation = "BEL", Id = new Guid("1661ef33-73b5-45f8-9927-9bfb37f39899")},
                new Country{ Name = "Denmark", Abbrevation = "DEN", Id = new Guid("2661ef33-73b5-45f8-9927-9bfb37f39899")},
            };
        }

        private IEnumerable<Scenario> SetupScenarios()
        {
            return new List<Scenario>
            {
                new Scenario{ Name = "UEFA2425", Id = new Guid("c5300dfa-f995-4bb3-9e2e-009b85752995"), NumberOfPot = 4, NumberOfTeamsPerPot = 9, NumberOfGamesPerPot = 2},
                new Scenario{ Name = "EPL", Id = new Guid("d5300dfa-f995-4bb3-9e2e-009b85752995"), NumberOfPot = 1, NumberOfTeamsPerPot = 20, NumberOfGamesPerPot = 19, HomeAndAwayPerOpponent = true},
                new Scenario{ Name = "3-2-1", Id = new Guid("92944679-54a6-4248-9bf8-e50e0774dedc"), NumberOfPot = 1, NumberOfTeamsPerPot = 3, NumberOfGamesPerPot = 2},
                new Scenario{ Name = "3-2-4", Id = new Guid("e2e36700-16f6-44de-a5c3-6acf484655c3"), NumberOfPot = 4, NumberOfTeamsPerPot = 3, NumberOfGamesPerPot = 2}
            };
        }
        private IEnumerable<ScenarioInstance> SetupScenarioInstances()
        {
            return new List<ScenarioInstance>();            
        }
    }
}
