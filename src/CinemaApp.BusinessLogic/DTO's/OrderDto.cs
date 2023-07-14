namespace CinemaApp.BusinessLogic.DTO_s
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public int PeopleId { get; set; }
        public int CategoryId { get; set; }
        public int Numberofticket { get; set; }
        public int SessionId { get; set; }
        public int CinemaId { get; set; }
        public int FilmId { get; set; }
        public double Duration { get; set; }
        public double Amount { get; set; }
        public DateTime dateoforder { get; set; }= DateTime.Now;
        public string Cashier;
        
       
    }
}
