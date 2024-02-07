using CsvHelper.Configuration;

namespace Football_data_reader
{
    public class MatchMap : ClassMap<Match>
    {
        public MatchMap() 
        {
            Map(m => m.Date).Name("date").TypeConverterOption.Format("yyyy-MM-dd");
            Map(m => m.HomeTeam).Name("home_team");
            Map(m => m.AwayTeam).Name("away_team");
            Map(m => m.HomeScore).Name("home_score");
            Map(m => m.AwayScore).Name("away_score");
            Map(m => m.Tournament).Name("tournament");
            Map(m => m.City).Name("city");
            Map(m => m.Country).Name("country");
            Map(m => m.Neutral).Name("neutral");
        }
    }
}
