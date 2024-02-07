using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace Football_data_reader
{
    public class DataHelper
    {
        List<Match> matches;
        private string filePath = "C:\\Users\\Shota\\Desktop\\OL-Assignments\\assignments\\Football data reader\\football_results.csv";

        public DataHelper()
        {
            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                MissingFieldFound = null,
            });
            csv.Context.RegisterClassMap<MatchMap>();
            matches = csv.GetRecords<Match>().ToList();
        }

        public void PrintMatchesCount()
        {
            Console.WriteLine("Total count of matches: " + matches.Count);
        }

        public void Top10ScoringCountries()
        {
            Dictionary<string, int> countryScores = new Dictionary<string, int>();

            foreach (var match in matches)
            {
                if (!countryScores.ContainsKey(match.HomeTeam))
                    countryScores[match.HomeTeam] = 0;
                if (!countryScores.ContainsKey(match.AwayTeam))
                    countryScores[match.AwayTeam] = 0;

                countryScores[match.HomeTeam] += match.HomeScore;
                countryScores[match.AwayTeam] += match.AwayScore;
            }

            var topScoringCountries = countryScores.OrderByDescending(a => a.Value).Take(10);

            Console.WriteLine("Top 10 scoring countries:\n");
            foreach (var country in topScoringCountries)
            {
                Console.WriteLine($"{country.Key}: {country.Value} goals\n");
            }
        }

        public void Top10FewestScoringCountries()
        {
            Dictionary<string, int> countryScores = new Dictionary<string, int>();

            foreach (var match in matches)
            {
                if (!countryScores.ContainsKey(match.HomeTeam))
                    countryScores[match.HomeTeam] = 0;
                if (!countryScores.ContainsKey(match.AwayTeam))
                    countryScores[match.AwayTeam] = 0;

                countryScores[match.HomeTeam] += match.HomeScore;
                countryScores[match.AwayTeam] += match.AwayScore;
            }

            var topScoringCountries = countryScores.OrderBy(a => a.Value).Take(10);

            Console.WriteLine("Top 10 fewest scoring countries:\n");
            foreach (var country in topScoringCountries)
            {
                Console.WriteLine($"{country.Key}: {country.Value} goals\n");
            }
        }
        public void Top10MostWins()
        {
            Dictionary<string, int> winsCount = new Dictionary<string, int>();

            foreach (var match in matches)
            {
                if (!winsCount.ContainsKey(match.HomeTeam))
                    winsCount[match.HomeTeam] = 0;
                if (!winsCount.ContainsKey(match.AwayTeam))
                    winsCount[match.AwayTeam] = 0;

                if (match.HomeScore > match.AwayScore)
                {
                    winsCount[match.HomeTeam]++;
                }
                else if (match.AwayScore > match.HomeScore)
                {
                    winsCount[match.AwayTeam]++;
                }
            }

            var mostWinsCountries = winsCount.OrderByDescending(a => a.Value).Take(10);

            Console.WriteLine("10 countries with the most wins:\n");
            foreach (var country in mostWinsCountries)
            {
                Console.WriteLine($"{country.Key}: {country.Value} wins\n");
            }
        }

        public void AverageGoalsAtHome()
        {
            Dictionary<string, int> goalsAtHome = new Dictionary<string, int>();
            Dictionary<string, int> matchesAtHome = new Dictionary<string, int>();

            foreach (var match in matches)
            {
                if (!goalsAtHome.ContainsKey(match.HomeTeam))
                {
                    goalsAtHome[match.HomeTeam] = 0;
                    matchesAtHome[match.HomeTeam] = 0;
                }

                goalsAtHome[match.HomeTeam] += match.HomeScore;
                matchesAtHome[match.HomeTeam]++;
            }

            Dictionary<string, double> averageGoalsAtHome = new Dictionary<string, double>();
            foreach (var country in goalsAtHome.Keys)
            {
                double averageGoals = (double)goalsAtHome[country] / matchesAtHome[country];
                averageGoalsAtHome[country] = averageGoals;
            }

            Console.WriteLine("Average number of goals scored at home by each country:\n");
            foreach (var country in averageGoalsAtHome)
            {
                Console.WriteLine($"{country.Key}: {country.Value:F2} goals\n");
            }
        }

        public void AverageGoalsOut()
        {
            Dictionary<string, int> totalGoals = new Dictionary<string, int>();
            Dictionary<string, int> totalMatches = new Dictionary<string, int>();

            foreach (var match in matches)
            {
                if (!totalGoals.ContainsKey(match.HomeTeam))
                {
                    totalGoals[match.HomeTeam] = 0;
                    totalMatches[match.HomeTeam] = 0;
                }

                totalGoals[match.HomeTeam] += match.HomeScore;
                totalMatches[match.HomeTeam]++;

                if (!totalGoals.ContainsKey(match.AwayTeam))
                {
                    totalGoals[match.AwayTeam] = 0;
                    totalMatches[match.AwayTeam] = 0;
                }

                totalGoals[match.AwayTeam] += match.AwayScore;
                totalMatches[match.AwayTeam]++;
            }

            Dictionary<string, double> averageGoalsPerOuting = new Dictionary<string, double>();
            foreach (var country in totalGoals.Keys)
            {
                double averageGoals = (double)totalGoals[country] / totalMatches[country];
                averageGoalsPerOuting[country] = averageGoals;
            }

            Console.WriteLine("Average number of goals scored per outing by each country:\n");
            foreach (var country in averageGoalsPerOuting)
            {
                Console.WriteLine($"{country.Key}: {country.Value:F2} goals\n");
            }
        }
    }
}
