namespace CinemaApp.DataAccess.Entities
{
    public class Place
    {
        public int PlaceId { get; set; }
        public int Numberofplace { get; set; }
        public string CinemaName { get; set; }
        public string CategoryName { get; set; }
        public int CinemaId { get; set; }
        public int CategoryId { get; set; }
        public Place() { }
    }
}
