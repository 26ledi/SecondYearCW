using CinemaApp.DataAccess.Entities;
using MySql.Data.MySqlClient;


namespace CinemaApp.DataAccess.Repositories
{
    public class CinemaDao
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Uid=root;Pwd=T#9758@qlph;Database=cinemapp;");

        private void Connect() 
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
        private void Close() 
        {
            try 
            {
                connection.Close();
            }
            catch (InvalidOperationException ex) 
            {
                throw ex;
            }
        }/// <summary>
        /// For Adding Cinema Into The DB
        /// </summary>
        /// <param name="cinema"></param>
        public void Insert(Cinema cinema)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO cinemas (cinema_id,name,adress,image) VALUES (@CinemaId,@Name,@Adress,@Image)";
            command.Parameters.AddWithValue("@CinemaId", cinema.CinemaId);
            command.Parameters.AddWithValue("@Name", cinema.Name);
            command.Parameters.AddWithValue("@Adress", cinema.Adress);
            command.Parameters.AddWithValue("@Image",cinema.Imagebytes);


            try
            {
                Connect();
                command.ExecuteNonQuery();// méthode ExecuteNonQuery() est utilisée pour exécuter une commande SQL
                                          // qui ne retourne pas de résultat
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                Close();
            }
        }
        /// <summary>
        /// Reading From the DB
        /// </summary>
        /// <returns></returns>
        public virtual List<Cinema> GetAll()
        {
            List<Cinema> list = new List<Cinema>();
            Connect();
            MySqlCommand command = new MySqlCommand();
            command.Connection=connection;
            command.CommandText = "select cinema_id,name,adress,image from cinemas";
            var reader = command.ExecuteReader();
            if(reader.HasRows) 
            {
                while(reader.Read()) 
                {
                    Cinema cinema = new Cinema();
                    cinema.CinemaId = Convert.ToInt32(reader.GetValue(0));
                    cinema.Name = reader.GetValue(1).ToString();
                    cinema.Adress = reader.GetValue(2).ToString();
                    cinema.Imagebytes = (byte[])reader.GetValue(3);
                        
                    list.Add(cinema);
                }
            }
            Close();
            return list;
        }
        /// <summary>
        /// Updating The DB
        /// </summary>
        /// <param name="cinema"></param>
        public void Update(Cinema cinema)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE cinemas SET name=@Name,adress=@Adress,image=@Image,WHERE cinema_id=@CinemaId";
            command.Parameters.AddWithValue("@CinemaId", cinema.CinemaId);
            command.Parameters.AddWithValue("@Name", cinema.Name);
            command.Parameters.AddWithValue("@Adress", cinema.Adress);
            command.Parameters.AddWithValue("@Image", cinema.Imagebytes);

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
        /// Delete Into The DB
        /// </summary>
        /// <param name="cinema"></param>
        public void Delete(Cinema cinema)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM cinemas WHERE cinema_id = @CinemaId";
            command.Parameters.AddWithValue("@CinemaId", cinema.CinemaId);
            try
            {
                Connect();
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                Close();
            }
        }
        public int GetById(string name)
        {
            Connect();
            Cinema cinema = new Cinema();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = $"select cinemas.cinema_id from cinemas where name={name}";
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cinema.CinemaId = Convert.ToInt32(reader.GetValue(0));
                }
            }
            Close();
            return cinema.CinemaId;

        }

    }
}
