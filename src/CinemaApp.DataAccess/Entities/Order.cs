namespace CinemaApp.DataAccess.Entities
{
    public class Order
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
        public DateTime Dateoforder { get; set; }
        public string Cashier { get; set; }
        public string CinemaName {get;set;}
        public double Average { get; set; }
        public  string FilmName { get; set; }
        public  double Rating { get; set; }

    }
}
