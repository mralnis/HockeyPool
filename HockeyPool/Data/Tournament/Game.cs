namespace HockeyPool.Data.Tournament
{
    public class Game
    {
        public int Id { get; set; }
        public int HomeCountryId { get; set; }
        public int GuestCountriesId { get; set; }
        public DateTime? GameTime { get; set; }
        public int? HomeCountryScore { get; set; }
        public int? GuestCountrScore { get; set; }
    }
}
