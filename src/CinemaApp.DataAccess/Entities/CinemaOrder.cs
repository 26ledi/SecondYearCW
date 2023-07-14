namespace CinemaApp.DataAccess.Entities
{
    public class CinemaOrder
    {
        public int CinemaOrderId { get; set; }
      
        public int CinemaId { get; set; }
        public int FilmId { get; set; }
        public CinemaOrder() { }
    }
}
