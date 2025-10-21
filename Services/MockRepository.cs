using UEFASwissFormatSelector.Models;

namespace UEFASwissFormatSelector.Services
{
    public class MockRepository : IRepository
    {
        private IUnitRepository<Club> _clubs;
        private IUnitRepository<Country> _countries;
        private IUnitRepository<Scenario> _scenarios;
        private IUnitRepository<ScenarioInstance> _scenarioInstances;
        public IUnitRepository<Club> Clubs
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

        public IUnitRepository<Country> Countries { get => _countries; set => _countries = value; }
        public IUnitRepository<Scenario> Scenarios { get => _scenarios; set => _scenarios = value; }
        public IUnitRepository<ScenarioInstance> ScenarioInstances { get => _scenarioInstances; set => _scenarioInstances = value; }

        public MockRepository()
        {
            _clubs = SetupClubs();
            _countries = SetupCountries();
            _scenarios = SetupScenarios();
            _scenarioInstances = SetupScenarioInstances();
        }
        public static MockUnitRepository<Club> SetupClubs()
        {
            return new MockUnitRepository<Club>
            {
                new Club{ Name = "Manchester City", CountryId = new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), Id = new Guid("742bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Liverpool", CountryId = new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), Id = new Guid("752bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Arsenal", CountryId = new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), Id = new Guid("762bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Manchester United", CountryId = new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), Id = new Guid("772bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Newcastle United", CountryId = new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), Id = new Guid("782bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "West Ham United", CountryId = new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), Id = new Guid("792bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Aston Villa", CountryId = new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), Id = new Guid("802bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Real Madrid", CountryId = new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), Id = new Guid("812bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Barcelona", CountryId = new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), Id = new Guid("822bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Atlético Madrid", CountryId = new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), Id = new Guid("832bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Sevilla", CountryId = new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), Id = new Guid("842bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Real Sociedad", CountryId = new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), Id = new Guid("852bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Villarreal", CountryId = new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), Id = new Guid("862bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Bayern Munich", CountryId = new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), Id = new Guid("872bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Borussia Dortmund", CountryId = new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), Id = new Guid("882bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Bayer Leverkusen", CountryId = new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), Id = new Guid("892bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Union Berlin", CountryId = new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), Id = new Guid("902bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "RB Leipzig", CountryId = new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), Id = new Guid("912bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Inter Milan", CountryId = new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), Id = new Guid("922bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Juventus", CountryId = new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), Id = new Guid("932bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "AC Milan", CountryId = new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), Id = new Guid("942bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Napoli", CountryId = new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), Id = new Guid("952bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Atalanta", CountryId = new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), Id = new Guid("952bf86e-5f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Roma", CountryId = new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), Id = new Guid("962bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Lazio", CountryId = new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), Id = new Guid("972bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Olympique de Marseille", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), Id = new Guid("982bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Paris Saint-Germain", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), Id = new Guid("992bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Lyon", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), Id = new Guid("002bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Lille", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), Id = new Guid("012bf86e-4f43-4465-9872-34f9b1281f9a")},
                new Club{ Name = "Monaco", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), Id = new Guid("012bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Benfica", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39855"), Id = new Guid("022bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Porto", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39855"), Id = new Guid("032bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Sporting CP", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39855"), Id = new Guid("042bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Ajax", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39866"), Id = new Guid("052bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Feyenoord", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39866"), Id = new Guid("062bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Celtic", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39877"), Id = new Guid("072bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Shakhtar Donetsk", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39888"), Id = new Guid("082bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Galatasaray", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39899"), Id = new Guid("092bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Red Star Belgrade", CountryId = new Guid("1661ef33-73b5-45f8-9927-9bfb37f39866"), Id = new Guid("102bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Dinamo Zagreb", CountryId = new Guid("1661ef33-73b5-45f8-9927-9bfb37f39877"), Id = new Guid("112bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Olympiacos", CountryId = new Guid("1661ef33-73b5-45f8-9927-9bfb37f39888"), Id = new Guid("122bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Club Brugge", CountryId = new Guid("1661ef33-73b5-45f8-9927-9bfb37f39899"), Id = new Guid("132bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Copenhagen", CountryId = new Guid("2661ef33-73b5-45f8-9927-9bfb37f39899"), Id = new Guid("142bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Red Bull Salzburg", CountryId = new Guid("1691ef33-73b5-45f8-9927-9bfb37f39899"), Id = new Guid("152bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Genk", CountryId = new Guid("1661ef33-73b5-45f8-9927-9bfb37f39899"), Id = new Guid("162bf86e-4f43-4465-9872-34f9b1281f8a")},
                new Club{ Name = "Sheriff Tiraspol", CountryId = new Guid("1961ef33-73b5-45f8-9927-9bfb37f39899"), Id = new Guid("172bf86e-4f43-4465-9872-34f9b1281f8a")},


                new Club{ Name = "PSV Eindhoven", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39866"), Id = new Guid("c16c0f65-533e-4ec1-a9bb-00ea900730f6")},
                new Club{ Name = "Young Boys", CountryId = new Guid("b4ba3641-ed96-4528-810b-f0987d1a4a70"), Id = new Guid("b544a383-4877-4dd4-ad2a-f89ea6b75d5d")},
                new Club{ Name = "Slovan Bratislava", CountryId = new Guid("87f77a33-880a-434d-b848-4ef803d9fd01"), Id = new Guid("478a6ca6-8edf-4a33-a186-903777893d31")},
                new Club{ Name = "Sparta Prague", CountryId = new Guid("806f85b8-30f1-4eb6-9bb1-cb24cfc98abc"), Id = new Guid("efe64f03-dbf6-4d16-8039-122ca0250aee")},
                new Club{ Name = "Bologna", CountryId = new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), Id = new Guid("eb73b033-ec94-4aa9-b1c4-daea9715ae48")},
                new Club{ Name = "Girona", CountryId = new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), Id = new Guid("a3cbfe68-d1d8-4f64-acb3-1b390b69129f")},
                new Club{ Name = "VfB Stuttgart", CountryId = new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), Id = new Guid("ac03a6df-7b04-446b-8772-299ab7988c68")},
                new Club{ Name = "Sturm Graz", CountryId = new Guid("1691ef33-73b5-45f8-9927-9bfb37f39899"), Id = new Guid("2f6feb10-8e68-4741-b302-6fe86dbf38ab")},
                new Club{ Name = "Brest", CountryId = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), Id = new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844")},
                
            };
        }
        public static MockUnitRepository<Country> SetupCountries()
        {
            return new MockUnitRepository<Country>
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
                new Country{ Name = "Austria", Abbrevation = "AUT", Id = new Guid("1691ef33-73b5-45f8-9927-9bfb37f39899")},
                new Country{ Name = "Moldova", Abbrevation = "MOL", Id = new Guid("1961ef33-73b5-45f8-9927-9bfb37f39899")},

                new Country{ Name = "Switzerland", Abbrevation = "SUI", Id = new Guid("b4ba3641-ed96-4528-810b-f0987d1a4a70")},
                new Country{ Name = "Slovakia", Abbrevation = "SVK", Id = new Guid("87f77a33-880a-434d-b848-4ef803d9fd01")},
                new Country{ Name = "Czech", Abbrevation = "CZE", Id = new Guid("806f85b8-30f1-4eb6-9bb1-cb24cfc98abc")},                
            };
        }

        public static MockUnitRepository<Scenario> SetupScenarios()
        {
            return new MockUnitRepository<Scenario>
            {
                new Scenario{ Name = "UEFA2425", Id = new Guid("c5300dfa-f995-4bb3-9e2e-009b85752995"), NumberOfPot = 4, NumberOfTeamsPerPot = 9, NumberOfGamesPerPot = 2},
                new Scenario{ Name = "EPL", Id = new Guid("d5300dfa-f995-4bb3-9e2e-009b85752995"), NumberOfPot = 1, NumberOfTeamsPerPot = 20, NumberOfGamesPerPot = 19, HomeAndAwayPerOpponent = true},
                new Scenario{ Name = "4-2-2", Id = new Guid("92944679-54a6-4248-9bf8-e50e0774dedc"), NumberOfPot = 2, NumberOfTeamsPerPot = 4, NumberOfGamesPerPot = 2},
                new Scenario{ Name = "3-2-4", Id = new Guid("e2e36700-16f6-44de-a5c3-6acf484655c3"), NumberOfPot = 4, NumberOfTeamsPerPot = 3, NumberOfGamesPerPot = 2}
            };
        }
        private MockUnitRepository<ScenarioInstance> SetupScenarioInstances()
        {
            return new MockUnitRepository<ScenarioInstance>();            
        }
    }
}
