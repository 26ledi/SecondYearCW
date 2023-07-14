using MySql.Data.MySqlClient;
using Order = CinemaApp.DataAccess.Entities.Order;

namespace CinemaApp.DataAccess.Repositories
{
    public class OrderDao
    {

        public MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Uid=root;Pwd=T#9758@qlph;Database=cinemapp;");
        public void Connect()
        {
            try
            {
                connection.Open();
            }
            catch (ArgumentNullException)
            {
                throw;
            }
        }

        public void Close()
        {
            try
            {
                connection.Close();
            }
            catch
            {
                throw;
            }

        }

        public void Insert(Order order)
        {
            Connect();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO orders (people_id,numberofticket,session_id,amount,category_id,film_id,cinema_id,dateoforder,cashier) VALUES (@PeopleId,@Numberofticket,@SessionId,@Amount,@CategoryId,@FilmId,@CinemaId,@Dateoforder,@Cashier)";
            command.Parameters.AddWithValue("@PeopleId",order.PeopleId);
            command.Parameters.AddWithValue("@Numberofticket",order.Numberofticket);
            command.Parameters.AddWithValue("@SessionId", order.SessionId);
            command.Parameters.AddWithValue("@Amount", order.Amount);
            command.Parameters.AddWithValue("@CategoryId", order.CategoryId);
            command.Parameters.AddWithValue("@FilmId", order.FilmId);
            command.Parameters.AddWithValue("@CinemaId", order.CinemaId);
            command.Parameters.AddWithValue("@Dateoforder", order.Dateoforder);
            command.Parameters.AddWithValue("@Cashier", order.Cashier);
            command.ExecuteNonQuery();// méthode ExecuteNonQuery() est utilisée pour exécuter une commande SQL
            Close();                             // qui ne retourne pas de résultat
        }
     
        public List<Order> GetAll()
        {
            List<Order> list = new List<Order>();

            Connect();

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "select order_id,people_id,numberofticket,session_id,amount,category_id,film_id,cinema_id,dateoforder,cashier from orders;";

            var reader = command.ExecuteReader();//for reading in the data base

            if (reader.HasRows)//if there is rows
            {
                while (reader.Read())
                {
                    Order order = new Order();
                    order.OrderId =Convert.ToInt32(reader.GetValue(0));
                    order.PeopleId= Convert.ToInt32(reader.GetValue(1));
                    order.Numberofticket= Convert.ToInt32(reader.GetValue(2));
                    order.SessionId= Convert.ToInt32(reader.GetValue(3));
                    order.Amount= Convert.ToDouble(reader.GetValue(4));
                    order.CategoryId= Convert.ToInt32(reader.GetValue(5));
                    order.FilmId = Convert.ToInt32(reader.GetValue(6));
                    order.CinemaId= Convert.ToInt32(reader.GetValue(7));
                    order.Dateoforder = Convert.ToDateTime(reader.GetValue(8));
                    order.Cashier = reader.GetValue(9).ToString();
                    list.Add(order);
                }
            }

            Close();
            return list;
        }
      
        public void Update(Order order)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE orders SET order_id=@OrderId,people_id=@PeopleId,numberofticket=@Numberofticket,session_id=@SessionId,amount=@Amount,category_id=@CategoryId,film_id=@FilmId,cinema_id=@CinemaId,dateoforder=@Dateoforder,cashier=@Cashier WHERE order_id=@OrderId";
            command.Parameters.AddWithValue("@OrderId", order.OrderId);
            command.Parameters.AddWithValue("@PeopleId", order.PeopleId);
            command.Parameters.AddWithValue("@Numberofticket", order.Numberofticket);
            command.Parameters.AddWithValue("@SessionId", order.SessionId);
            command.Parameters.AddWithValue(",@Amount", order.Amount);
            command.Parameters.AddWithValue("@CategoryId", order.CategoryId);
            command.Parameters.AddWithValue("@FilmId", order.FilmId);
            command.Parameters.AddWithValue("@CinemaId", order.CinemaId);
            command.Parameters.AddWithValue("@Dateoforder", order.Dateoforder);
            command.Parameters.AddWithValue("@Cashier", order.Cashier);
            try
            {
                Connect();
                command.ExecuteNonQuery();

            }
            catch (MySqlException ex) { throw ex; }
            finally
            {
                Close();
            }
        }
      
        public void Delete(Order order)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM orders Where order_id=@OrderId";
            command.Parameters.AddWithValue("@OrderId", order.OrderId);

            try
            {
                Connect();
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex) { throw ex; }
            finally
            {
                Close();
            }
        }
        public List<Order> GetAllOrderByName(string name)
        {
            List<Order> list = new List<Order>();

            Connect();

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "select orders.order_id,people.people_id,orders.numberofticket,sessions.session_id" +
                "\r\n,orders.amount,categories.category_id,films.film_id,cinemas.cinema_id,orders.dateoforder,orders.cashier" +
                "\r\nfrom orders join people on orders.people_id=people.people_id" +
                "\r\njoin sessions on orders.session_id=sessions.session_id" +
                "\r\njoin categories on orders.category_id=categories.category_id" +
                "\r\njoin films on orders.film_id=films.film_id" +
                "\r\njoin cinemas on orders.cinema_id=cinemas.cinema_id"+
                $"\r\nwhere people.name='{name}'";

            var reader = command.ExecuteReader();//for reading in the data base

            if (reader.HasRows)//if there is rows
            {
                while (reader.Read())
                {
                    Order order = new Order();
                    order.OrderId = Convert.ToInt32(reader.GetValue(0));
                    order.PeopleId = Convert.ToInt32(reader.GetValue(1));
                    order.Numberofticket = Convert.ToInt32(reader.GetValue(2));
                    order.SessionId = Convert.ToInt32(reader.GetValue(3));
                    order.Amount = Convert.ToDouble(reader.GetValue(4));
                    order.CategoryId = Convert.ToInt32(reader.GetValue(5));
                    order.FilmId = Convert.ToInt32(reader.GetValue(6));
                    order.CinemaId = Convert.ToInt32(reader.GetValue(7));
                    order.Dateoforder = Convert.ToDateTime(reader.GetValue(8));
                    order.Cashier = reader.GetValue(9).ToString();
                    list.Add(order);
                }
            }

            Close();
            return list;
        }
        public List<Order> GetAverageByCinemas(DateTime startDate,DateTime endDate) 
        {
            List<Order> list = new List<Order>();
            Connect();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT cinemas.name AS cinema, AVG(orders.people_id) AS averageViewers FROM orders" +
               " JOIN cinemas ON orders.cinema_id = cinemas.cinema_id" +
               $" WHERE orders.dateoforder >='{startDate.ToString("yyyy-MM-dd")}' AND orders.dateoforder <='{endDate.ToString("yyyy-MM-dd")}'" +
               " GROUP BY cinemas.name";

            var reader = command.ExecuteReader();//for reading in the data base

            if (reader.HasRows)//if there is rows
            {
                while (reader.Read())
                {
                    Order order = new Order();
                    order.CinemaName=reader.GetValue(0).ToString();
                    order.Average = Convert.ToDouble(reader.GetValue(1));
                    list.Add(order);
                }
            }

            Close();
            return list;
        }
        public List<Order> GetPopularFilms() 
        {
            List<Order> list = new List<Order>();
            Connect();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT films.name, films.rating, COUNT(orders.numberofticket) AS totalTickets" +
                "\r\nFROM orders" +
                "\r\nJOIN films ON orders.film_id = films.film_id" +
                "\r\nWHERE films.rating > 7" +
                "\r\nGROUP BY films.name, films.rating" +
                "\r\nHAVING COUNT(orders.numberofticket) = (" +
                "\r\n    SELECT MAX(ticketCount)" +
                "\r\n    FROM (" +
                "\r\n        SELECT COUNT(numberofticket) AS ticketCount" +
                "\r\n        FROM orders" +
                "\r\n        JOIN films ON orders.film_id = films.film_id" +
                "\r\n        WHERE films.rating > 7" +
                "\r\n        GROUP BY films.name, films.rating" +
                "\r\n    ) AS ticketCounts" +
                "\r\n)" +
                "\r\n";
            var reader = command.ExecuteReader();//for reading in the data base

            if (reader.HasRows)//if there is rows
            {
                while (reader.Read())
                {
                    Order order = new Order();
                    order.FilmName = reader.GetValue(0).ToString();
                    order.Rating = Convert.ToDouble(reader.GetValue(1));
                    list.Add(order);
                }
            }

            Close();
            return list;
        }
        public List<Order> GetCashiers(DateTime startDate, DateTime endDate)
        {
            List<Order> list = new List<Order>();
            Connect();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT orders.cashier, cinemas.name AS cinemaName, SUM(orders.amount) AS totalAmount FROM orders " +
                                  "JOIN cinemas ON orders.cinema_id = cinemas.cinema_id " +
                                  $"WHERE orders.dateoforder >= '{startDate.ToString("yyyy-MM-dd")}' AND orders.dateoforder <= '{endDate.ToString("yyyy-MM-dd")}' " +
                                  "GROUP BY orders.cashier, cinemas.name";
            var reader = command.ExecuteReader();//for reading in the data base

            if (reader.HasRows)//if there is rows
            {
                while (reader.Read())
                {
                    Order order = new Order();
                    order.Cashier = reader.GetValue(0).ToString();
                    order.CinemaName = reader.GetValue(1).ToString();
                    order.Amount = Convert.ToDouble(reader.GetValue(2));
                    list.Add(order);
                }
            }

            Close();
            return list;
        }


    }
}
