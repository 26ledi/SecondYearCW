using CinemaApp.DataAccess.Entities;
using MySql.Data.MySqlClient;

namespace CinemaApp.DataAccess.Repositories
{
    public class PlaceDao
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Uid=root;Pwd=T#9758@qlph;Database=cinemapp;");

        private void Connect()
        {
            try
            {
                connection.Open();
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
        }
        private void Close()
        {
            try
            {
                connection.Close();
            }
            catch (InvalidOperationException ex)
            { throw ex; }
        }
        /// <summary>
        /// Getting from the DB
        /// </summary>
        /// <returns></returns>
        public List<Place> GetAll()
        {
            List<Place> list = new List<Place>();
            Connect();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "select places_id,number_of_place,cinema_id,category_id from places";

            var reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Place place = new Place();
                    place.PlaceId = Convert.ToInt32(reader.GetValue(0));
                    place.Numberofplace = Convert.ToInt32(reader.GetValue(1));
                    place.CinemaId = Convert.ToInt32(reader.GetValue(2));
                    place.CategoryId = Convert.ToInt32(reader.GetValue(3));

                    list.Add(place);
                }
            }
            Close();
            return list;

        }
        public void Update(Place place)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE places SET numberofplace=@Numberofplace WHERE place_id=@PlaceId";
            command.Parameters.AddWithValue("@Numberofplace", place.Numberofplace);
            command.Parameters.AddWithValue("@PlaceId", place.PlaceId);
            try
            {
                Connect();
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex) { throw ex; }
            finally { Close(); }
        }
        public List<Place> GetPlacesByCineName(string cinename)
        {
            List<Place> list = new List<Place>();
            Connect();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "select places.places_id,cinemas.name,categories.name as category,places.number_of_place from places " +
                       "join cinemas on places.cinema_id = cinemas.cinema_id " +
                       "join categories on places.category_id = categories.category_id " +
                       $"where cinemas.name = '{cinename}'";


            var reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Place place = new Place();
                    place.PlaceId = Convert.ToInt32(reader.GetValue(0));
                    place.CinemaName = reader.GetValue(1).ToString();
                    place.CategoryName = reader.GetValue(2).ToString();
                    place.Numberofplace = Convert.ToInt32(reader.GetValue(3));

                    list.Add(place);
                }
            }
            Close();
            return list;
        }
    }
}
