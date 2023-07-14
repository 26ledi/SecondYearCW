namespace CinemaApp.BusinessLogic.DTO_s
{
    public class FilmDto
    {
        public int FilmId { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Duration { get; set; }
        public double Rating { get; set; }
        public string Session { get; set; } = string.Empty;
        public double Price { get; set; }
        public byte[] Imagebytes { get; set; }
        public DateTime Diffusion { get; set; }
      
    }
}
