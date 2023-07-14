namespace CinemaApp.DataAccess.Entities
{
    public class Session
    {
        public int SessionId { get; set; }
        public int FilmId { get; set; }
        public string Time { get; set; }

        public Session() { }
    }
}
