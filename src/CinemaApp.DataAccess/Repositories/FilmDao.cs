using CinemaApp.DataAccess.Entities;
using MySql.Data.MySqlClient;

namespace CinemaApp.DataAccess.Repositories
{
    public class FilmDao
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Uid=root;Pwd=T#9758@qlph;Database=cinemapp;");

        public void Connect() 
        {
            try 
            {
                connection.Open();
            }
            catch(InvalidOperationException ex) 
            {
                throw ex;
            }
        }
        public void Close() 
        {
            try 
            {
                connection.Close();
            }
            catch (InvalidOperationException ex) 
            {
                throw ex;
            }
        }
        /// <summary>
        /// Adding Film into the DB
        /// </summary>
        /// <param name="film"></param>
        public void Insert(Film film)
        {
           Connect();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO films (name,duration,rating,image,price,diffusion) VALUES (@Name,@Duration,@Rating,@Image,@Price,@Diffusion)";
            command.Parameters.AddWithValue("@Name", film.Name);
            command.Parameters.AddWithValue("@Duration", film.Duration);
            command.Parameters.AddWithValue("@Rating", film.Rating);
            command.Parameters.AddWithValue("@Image", film.Imagebytes);
            command.Parameters.AddWithValue("@Price", film.Price);
            command.Parameters.AddWithValue("@Diffusion", film.Diffusion);
            command.ExecuteNonQuery();
            Close();
            

        }
        /// <summary>
        /// Reading From The DB
        /// </summary>
        /// <returns></returns>
        public List<Film> GetAll() 
        {
            List<Film>list = new List<Film>();
            Connect();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "select film_id,name,duration,rating,image,price,diffusion from films";

            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Film film = new Film();
                    film.FilmId = Convert.ToInt32(reader.GetValue(0));
                    film.Name = reader.GetValue(1).ToString();
                    film.Duration = Convert.ToDouble(reader.GetValue(2));
                    film.Rating = Convert.ToDouble(reader.GetValue(3));
                    film.Imagebytes = (byte[])reader.GetValue(4);
                    film.Price = Convert.ToDouble(reader.GetValue(5));
                    film.Diffusion = Convert.ToDateTime(reader.GetValue(6));


                    list.Add(film);
                }
            }
            Close();
            return list;
        }
        /// <summary>
        /// For Updating the DB
        /// </summary>
        /// <param name="film"></param>
        public void Update(Film film)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE films SET film_id=@FilmId,name=@Name,duration=@Duration,rating=@Rating,image=@Image,price=@Price,diffusion=@Diffusion WHERE film_id=@FilmId";
            command.Parameters.AddWithValue("@FilmId", film.FilmId);
            command.Parameters.AddWithValue("@name", film.Name);
            command.Parameters.AddWithValue("@Duration",film.Duration);
            command.Parameters.AddWithValue("@Rating", film.Rating);
            command.Parameters.AddWithValue("@Image", film.Imagebytes);
            command.Parameters.AddWithValue("@Price", film.Price);
            command.Parameters.AddWithValue("@Diffusion", film.Diffusion);
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
        /// <summary>
        /// For Deleting into the DB
        /// </summary>
        /// <param name="film"></param>
        public void Delete(Film film)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM films Where film_id=@FilmId";
            command.Parameters.AddWithValue("@FilmId", film.FilmId);
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
       

        public virtual List<Film> GetFilmsByCinemaName(string name)
        {
            List<Film> list = new List<Film>();
            Connect();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "select distinct films.film_id,films.name,duration,rating,films.image,films.price,DATE_FORMAT(films.diffusion,'%Y-%m-%d')as diffusion" +
                "\r\nfrom films join cinemas_films on films.film_id = cinemas_films.film_id" +
                "\r\njoin cinemas on cinemas_films.cinema_id = cinemas.cinema_id" +
                "\r\nwhere cinemas.name = '" + name + "'";

            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Film film = new Film();
                    film.FilmId = Convert.ToInt32(reader.GetValue(0));
                    film.Name = reader.GetValue(1).ToString();
                    film.Duration = Convert.ToDouble(reader.GetValue(2));
                    film.Rating = Convert.ToDouble(reader.GetValue(3));
                    film.Imagebytes = (byte[])reader.GetValue(4);
                    film.Price = Convert.ToDouble(reader.GetValue(5));
                    film.Diffusion = Convert.ToDateTime(reader.GetValue(6));

                    list.Add(film);
                }
            }
            Close();

            return list;
        }
       
    }
}

