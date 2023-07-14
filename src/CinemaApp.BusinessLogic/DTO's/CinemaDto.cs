namespace CinemaApp.BusinessLogic.DTO_s
{
    public class CinemaDto
    {
        public int CinemaId { get; set; }

        public string Name { get; set; }
        public string Adress { get; set; }
        public int SessionId { get; set; }
        public byte[] Imagebytes { get; set; }
    }
}
