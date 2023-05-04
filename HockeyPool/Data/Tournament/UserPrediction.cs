namespace HockeyPool.Data.Tournament
{
    public class UserPrediction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GameId { get; set; }
        public int? HomeCountryScore { get; set; }
        public int? GuestCountrScore { get; set; }
    }
}
