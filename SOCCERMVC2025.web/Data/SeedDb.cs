using SOCCERMVC2025.web.Data.Entities;

namespace SOCCERMVC2025.web.Data;

public class SeedDb
{
    private readonly DataContext _context;

    public SeedDb(DataContext context)
    {
        _context = context;
    }

    public async Task SeedAsync()
    {
        await _context.Database.EnsureCreatedAsync();
        await CheckTeamAsync();
        await CheckTournamentsAsync();
    }

    private async Task CheckTeamAsync()
    {
        if (!_context.Teams.Any())
        {
            AddTeam("Afghanistan");
            AddTeam("Albania");
            AddTeam("Algeria");
            AddTeam("American Samoa");
            AddTeam("Andorra");
            AddTeam("Angola");
            AddTeam("Anguilla");
            AddTeam("Antigua and Barbuda");
            AddTeam("Argentina");
            AddTeam("Armenia");
            AddTeam("Aruba");
            AddTeam("Australia");
            AddTeam("Austria");
            AddTeam("Azerbaijan");
            AddTeam("Bahamas");
            AddTeam("Bahrain");
            AddTeam("Bangladesh");
            AddTeam("Barbados");
            AddTeam("Belarus");
            AddTeam("Belgium");
            AddTeam("Belize");
            AddTeam("Benin");
            AddTeam("Bermuda");
            AddTeam("Bhutan");
            AddTeam("Bolivia");
            AddTeam("Bonaire");
            AddTeam("Bosnia and Herzegovina");
            AddTeam("Botswana");
            AddTeam("Brazil");
            AddTeam("British Virgin Islands");
            AddTeam("Brunei");
            AddTeam("Bulgaria");
            AddTeam("Burkina Faso");
            AddTeam("Burundi");
            AddTeam("Cambodia");
            AddTeam("Cameroon");
            AddTeam("Canada");
            AddTeam("Cape Verde");
            AddTeam("Cayman Islands");
            AddTeam("Central African Republic");
            AddTeam("Chad");
            AddTeam("Chile");
            AddTeam("China PR");
            AddTeam("Chinese Taipei");
            AddTeam("Colombia");
            AddTeam("Comoros");
            AddTeam("Congo");
            AddTeam("Congo DR");
            AddTeam("Cook Islands");
            AddTeam("Costa Rica");
            AddTeam("Côte d'Ivoire");
            AddTeam("Croatia");
            AddTeam("Cuba");
            AddTeam("Curaçao");
            AddTeam("Cyprus");
            AddTeam("Czechia");
            AddTeam("Denmark");
            AddTeam("Djibouti");
            AddTeam("Dominica");
            AddTeam("Dominican Republic");
            AddTeam("Ecuador");
            AddTeam("Egypt");
            AddTeam("El Salvador");
            AddTeam("England");
            AddTeam("Equatorial Guinea");
            AddTeam("Eritrea");
            AddTeam("Estonia");
            AddTeam("Eswatini");
            AddTeam("Ethiopia");
            AddTeam("Faroe Islands");
            AddTeam("Federated States of Micronesia");
            AddTeam("Fiji");
            AddTeam("Finland");
            AddTeam("France");
            AddTeam("French Guiana");
            AddTeam("Gabon");
            AddTeam("Gambia");
            AddTeam("Georgia");
            AddTeam("Germany");
            AddTeam("Ghana");
            AddTeam("Gibraltar");
            AddTeam("Greece");
            AddTeam("Grenada");
            AddTeam("Guadeloupe");
            AddTeam("Guam");
            AddTeam("Guatemala");
            AddTeam("Guinea");
            AddTeam("Guinea-Bissau");
            AddTeam("Guyana");
            AddTeam("Haiti");
            AddTeam("Honduras");
            AddTeam("Hong Kong");
            AddTeam("Hungary");
            AddTeam("Iceland");
            AddTeam("India");
            AddTeam("Indonesia");
            AddTeam("IR Iran");
            AddTeam("Iraq");
            AddTeam("Israel");
            AddTeam("Italy");
            AddTeam("Jamaica");
            AddTeam("Japan");
            AddTeam("Jordan");
            AddTeam("Kazakhstan");
            AddTeam("Kenya");
            AddTeam("Kiribati");
            AddTeam("Korea DPR");
            AddTeam("Korea Republic");
            AddTeam("Kosovo");
            AddTeam("Kuwait");
            AddTeam("Kyrgyzstan");
            AddTeam("Laos");
            AddTeam("Latvia");
            AddTeam("Lebanon");
            AddTeam("Lesotho");
            AddTeam("Liberia");
            AddTeam("Libya");
            AddTeam("Liechtenstein");
            AddTeam("Lithuania");
            AddTeam("Luxembourg");
            AddTeam("Macau");
            AddTeam("Madagascar");
            AddTeam("Malawi");
            AddTeam("Malaysia");
            AddTeam("Maldives");
            AddTeam("Mali");
            AddTeam("Malta");
            AddTeam("Marshall Islands");
            AddTeam("Martinique");
            AddTeam("Mauritania");
            AddTeam("Mauritius");
            AddTeam("Mexico");
            AddTeam("Moldova");
            AddTeam("Monaco");
            AddTeam("Mongolia");
            AddTeam("Montenegro");
            AddTeam("Montserrat");
            AddTeam("Morocco");
            AddTeam("Mozambique");
            AddTeam("Myanmar");
            AddTeam("Namibia");
            AddTeam("Nauru");
            AddTeam("Nepal");
            AddTeam("Netherlands");
            AddTeam("New Caledonia");
            AddTeam("New Zealand");
            AddTeam("Nicaragua");
            AddTeam("Niger");
            AddTeam("Nigeria");
            AddTeam("North Macedonia");
            AddTeam("Northern Ireland");
            AddTeam("Northern Mariana Islands");
            AddTeam("Norway");
            AddTeam("Oman");
            AddTeam("Pakistan");
            AddTeam("Palau");
            AddTeam("Palestine");
            AddTeam("Panama");
            AddTeam("Papua New Guinea");
            AddTeam("Paraguay");
            AddTeam("Peru");
            AddTeam("Philippines");
            AddTeam("Poland");
            AddTeam("Portugal");
            AddTeam("Puerto Rico");
            AddTeam("Qatar");
            AddTeam("Republic of Ireland");
            AddTeam("Réunion");
            AddTeam("Romania");
            AddTeam("Russia");
            AddTeam("Rwanda");
            AddTeam("Saint Kitts and Nevis");
            AddTeam("Saint Lucia");
            AddTeam("Saint Martin");
            AddTeam("Saint Vincent and the Grenadines");
            AddTeam("Samoa");
            AddTeam("San Marino");
            AddTeam("São Tomé and Príncipe");
            AddTeam("Saudi Arabia");
            AddTeam("Scotland");
            AddTeam("Senegal");
            AddTeam("Serbia");
            AddTeam("Seychelles");
            AddTeam("Sierra Leone");
            AddTeam("Singapore");
            AddTeam("Sint Maarten");
            AddTeam("Slovakia");
            AddTeam("Slovenia");
            AddTeam("Solomon Islands");
            AddTeam("Somalia");
            AddTeam("South Africa");
            AddTeam("South Sudan");
            AddTeam("Spain");
            AddTeam("Sri Lanka");
            AddTeam("Sudan");
            AddTeam("Suriname");
            AddTeam("Sweden");
            AddTeam("Switzerland");
            AddTeam("Syria");
            AddTeam("Tahiti");
            AddTeam("Tajikistan");
            AddTeam("Tanzania");
            AddTeam("Thailand");
            AddTeam("Timor-Leste");
            AddTeam("Togo");
            AddTeam("Tonga");
            AddTeam("Trinidad and Tobago");
            AddTeam("Tunisia");
            AddTeam("Turkiye");
            AddTeam("Turkmenistan");
            AddTeam("Turks and Caicos Islands");
            AddTeam("Tuvalu");
            AddTeam("Uganda");
            AddTeam("Ukraine");
            AddTeam("United Arab Emirates");
            AddTeam("United States");
            AddTeam("Uruguay");
            AddTeam("US Virgin Islands");
            AddTeam("Uzbekistan");
            AddTeam("Vanuatu");
            AddTeam("Vatican City");
            AddTeam("Venezuela");
            AddTeam("Vietnam");
            AddTeam("Wales");
            AddTeam("Yemen");
            AddTeam("Zambia");
            AddTeam("Zanzibar");
            AddTeam("Zimbabwe");
            await _context.SaveChangesAsync();
        }
    }

    private void AddTeam(string name)
    {
        _context.Teams.Add(new TeamEntity { Name = name, LogoPath = $"~/images/Teams/{name}.png" });
    }

    private async Task CheckTournamentsAsync()
    {
        if (!_context.Tournaments.Any())
        {
            var startDate = DateTime.Today.AddMonths(2).ToUniversalTime();
            var endDate = DateTime.Today.AddMonths(3).ToUniversalTime();

            _context.Tournaments.Add(new TournamentEntity
            {
                StartDate = startDate,
                EndDate = endDate,
                IsActive = true,
                LogoPath = $"~/images/Tournaments/fifa.jpg",
                Name = "Copa Mundial FIFA United 2026",
                Groups = new List<GroupEntity>
                    {
                        new GroupEntity
                        {
                             Name = "A",
                             GroupDetails = new List<GroupDetailEntity>
                             {
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Mexico") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "South Africa") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Korea Republic") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Czechia") }
                             },
                             Matches = new List<MatchEntity>
                             {
                                 new MatchEntity
                                 {
                                     Date = startDate.AddHours(14),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Mexico"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "South Africa")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddHours(17),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Korea Republic"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Czechia")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(4).AddHours(14),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Mexico"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Korea Republic")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(4).AddHours(17),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Czechia"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "South Africa")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(9).AddHours(16),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Czechia"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Mexico")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(9).AddHours(16),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "South Africa"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Korea Republic")
                                 }
                             }
                        },
                        new GroupEntity
                        {
                             Name = "B",
                             GroupDetails = new List<GroupDetailEntity>
                             {
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Canada") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Bosnia and Herzegovina") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Qatar") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Switzerland") }
                             },
                             Matches = new List<MatchEntity>
                             {
                                 new MatchEntity
                                 {
                                     Date = startDate.AddHours(14),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Canada"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Bosnia and Herzegovina")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddHours(17),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Qatar"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Switzerland")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(4).AddHours(14),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Canada"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Qatar")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(4).AddHours(17),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Switzerland"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Bosnia and Herzegovina")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(9).AddHours(16),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Switzerland"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Canada")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(9).AddHours(16),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Bosnia and Herzegovina"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Qatar")
                                 }
                             }
                        },
                        new GroupEntity
                        {
                             Name = "C",
                             GroupDetails = new List<GroupDetailEntity>
                             {
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Brasil") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Morocco") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Haiti") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Scotland") }
                             },
                             Matches = new List<MatchEntity>
                             {
                                 new MatchEntity
                                 {
                                     Date = startDate.AddHours(14),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Brasil"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Morocco")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddHours(17),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Haiti"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Scotland")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(4).AddHours(14),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Brasil"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Haiti")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(4).AddHours(17),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Scotland"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Morocco")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(9).AddHours(16),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Scotland"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Brasil")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(9).AddHours(16),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Morocco"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Haiti")
                                 }
                             }
                        },
                        new GroupEntity
                        {
                             Name = "D",
                             GroupDetails = new List<GroupDetailEntity>
                             {
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "United States") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Paraguay") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Australia") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Turkiye") }
                             },
                             Matches = new List<MatchEntity>
                             {
                                 new MatchEntity
                                 {
                                     Date = startDate.AddHours(14),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "United States"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Paraguay")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddHours(17),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Australia"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Turkiye")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(4).AddHours(14),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "United States"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Australia")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(4).AddHours(17),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Turkiye"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Paraguay")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(9).AddHours(16),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Turkiye"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "United States")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(9).AddHours(16),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Paraguay"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Australia")
                                 }
                             }
                        },
                        new GroupEntity
                        {
                             Name = "E",
                             GroupDetails = new List<GroupDetailEntity>
                             {
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Germany") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Curaçao") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Côte d'Ivoire") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Ecuador") }
                             },
                             Matches = new List<MatchEntity>
                             {
                                 new MatchEntity
                                 {
                                     Date = startDate.AddHours(14),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Germany"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Curaçao")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddHours(17),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Côte d'Ivoire"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Ecuador")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(4).AddHours(14),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Germany"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Côte d'Ivoire")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(4).AddHours(17),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Ecuador"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Curaçao")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(9).AddHours(16),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Ecuador"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Germany")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(9).AddHours(16),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Curaçao"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Côte d'Ivoire")
                                 }
                             }
                        },
                        new GroupEntity
                        {
                             Name = "F",
                             GroupDetails = new List<GroupDetailEntity>
                             {
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Netherlands") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Japan") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Sweden") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Tunisia") }
                             },
                             Matches = new List<MatchEntity>
                             {
                                 new MatchEntity
                                 {
                                     Date = startDate.AddHours(14),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Netherlands"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Japan")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddHours(17),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Sweden"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Tunisia")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(4).AddHours(14),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Netherlands"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Sweden")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(4).AddHours(17),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Tunisia"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Japan")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(9).AddHours(16),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Tunisia"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Netherlands")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(9).AddHours(16),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Japan"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Sweden")
                                 }
                             }
                        },
                        new GroupEntity
                        {
                             Name = "G",
                             GroupDetails = new List<GroupDetailEntity>
                             {
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Belgium") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Egypt") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "IR Iran") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "New Zealand") }
                             },
                             Matches = new List<MatchEntity>
                             {
                                 new MatchEntity
                                 {
                                     Date = startDate.AddHours(14),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Belgium"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Egypt")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddHours(17),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "IR Iran"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "New Zealand")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(4).AddHours(14),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Belgium"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "IR Iran")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(4).AddHours(17),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "New Zealand"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Egypt")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(9).AddHours(16),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "New Zealand"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Belgium")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(9).AddHours(16),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Egypt"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "IR Iran")
                                 }
                             }
                        },
                        new GroupEntity
                        {
                             Name = "H",
                             GroupDetails = new List<GroupDetailEntity>
                             {
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Spain") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Cape Verde") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Saudi Arabia") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Uruguay") }
                             },
                             Matches = new List<MatchEntity>
                             {
                                 new MatchEntity
                                 {
                                     Date = startDate.AddHours(14),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Spain"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Cape Verde")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddHours(17),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Saudi Arabia"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Uruguay")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(4).AddHours(14),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Spain"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Saudi Arabia")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(4).AddHours(17),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Uruguay"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Cape Verde")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(9).AddHours(16),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Uruguay"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Spain")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(9).AddHours(16),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Cape Verde"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Saudi Arabia")
                                 }
                             }
                        },
                        new GroupEntity
                        {
                             Name = "I",
                             GroupDetails = new List<GroupDetailEntity>
                             {
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "France") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Senegal") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Iraq") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Norway") }
                             },
                             Matches = new List<MatchEntity>
                             {
                                 new MatchEntity
                                 {
                                     Date = startDate.AddHours(14),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "France"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Senegal")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddHours(17),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Iraq"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Norway")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(4).AddHours(14),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "France"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Iraq")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(4).AddHours(17),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Norway"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Senegal")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(9).AddHours(16),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Norway"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "France")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(9).AddHours(16),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Senegal"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Iraq")
                                 }
                             }
                        },
                        new GroupEntity
                        {
                             Name = "J",
                             GroupDetails = new List<GroupDetailEntity>
                             {
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Argentina") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Algeria") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Austria") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Jordan") }
                             },
                             Matches = new List<MatchEntity>
                             {
                                 new MatchEntity
                                 {
                                     Date = startDate.AddHours(14),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Argentina"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Algeria")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddHours(17),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Austria"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Jordan")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(4).AddHours(14),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Argentina"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Austria")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(4).AddHours(17),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Jordan"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Algeria")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(9).AddHours(16),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Jordan"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Argentina")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(9).AddHours(16),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Algeria"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Austria")
                                 }
                             }
                        },
                        new GroupEntity
                        {
                             Name = "K",
                             GroupDetails = new List<GroupDetailEntity>
                             {
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Portugal") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Cape Verde") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Uzbekistan") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Colombia") }
                             },
                             Matches = new List<MatchEntity>
                             {
                                 new MatchEntity
                                 {
                                     Date = startDate.AddHours(14),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Portugal"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Cape Verde")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddHours(17),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Uzbekistan"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Colombia")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(4).AddHours(14),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Portugal"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Uzbekistan")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(4).AddHours(17),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Colombia"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Cape Verde")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(9).AddHours(16),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Colombia"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Portugal")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(9).AddHours(16),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Cape Verde"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Uzbekistan")
                                 }
                             }
                        },
                        new GroupEntity
                        {
                             Name = "L",
                             GroupDetails = new List<GroupDetailEntity>
                             {
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "England") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Croatia") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Ghana") },
                                 new GroupDetailEntity { Team = _context.Teams.FirstOrDefault(t => t.Name == "Panama") }
                             },
                             Matches = new List<MatchEntity>
                             {
                                 new MatchEntity
                                 {
                                     Date = startDate.AddHours(14),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "England"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Croatia")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddHours(17),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Ghana"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Panama")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(4).AddHours(14),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "England"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Ghana")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(4).AddHours(17),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Panama"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Croatia")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(9).AddHours(16),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Panama"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "England")
                                 },
                                 new MatchEntity
                                 {
                                     Date = startDate.AddDays(9).AddHours(16),
                                     Local = _context.Teams.FirstOrDefault(t => t.Name == "Croatia"),
                                     Visitor = _context.Teams.FirstOrDefault(t => t.Name == "Ghana")
                                 }
                             }
                        },
                    }
            });
            await _context.SaveChangesAsync();
        }
    }
}