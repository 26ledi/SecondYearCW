namespace CinemaApp.DataAccess.Entities
{
    public class Film
    {
        public int FilmId { get; set; }
        public string Name { get; set; }
        public double Duration { get; set; }
        public double Rating { get; set; }
        public string Session { get; set; }
        public double Price { get; set; }
        public byte[] Imagebytes { get; set; }
        public DateTime Diffusion { get; set; }
        
        public Film() { }
    }
}
