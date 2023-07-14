namespace CinemaApp.DataAccess.Entities
{
    public class Cinema
    {
        public int CinemaId { get; set; }
       
        public string Name { get;set; }
        public string Adress { get; set; }
        public int SessionId { get; set; }
        public byte[] Imagebytes { get; set; } 
        public Cinema() { }
    }
}
