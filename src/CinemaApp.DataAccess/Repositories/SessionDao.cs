using CinemaApp.DataAccess.Entities;
using MySql.Data.MySqlClient;

namespace CinemaApp.DataAccess.Repositories
{
    public class SessionDao
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
        public void Insert(Session session)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO sessions (session_id,film_id,time) VALUES (@SessionId,@FilmId,@Time)";
            command.Parameters.AddWithValue("@SessionId", session.SessionId);
            command.Parameters.AddWithValue("@FilmId", session.FilmId);
            command.Parameters.AddWithValue("@Time", session.Time);


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

        public List<Session> GetAll()
        {
            List<Session> list = new List<Session>();
            Connect();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "select session_id,film_id,time from sessions";
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Session session = new Session();
                    session.SessionId = Convert.ToInt32(reader.GetValue(0));
                    session.FilmId = Convert.ToInt32(reader.GetValue(1));
                    session.Time = reader.GetValue(2).ToString();


                    list.Add(session);
                }
            }
            Close();
            return list;

        }
        public void Update(Session session)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE sessions SET name=@Time,film_id=@FilmId WHERE session_id=@SessionId";
            command.Parameters.AddWithValue("@Time", session.Time);
            command.Parameters.AddWithValue("@FilmId", session.FilmId);
            command.Parameters.AddWithValue("@SessionId", session.SessionId);

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
        public void Delete(Session session)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM sessions Where session_id=@SessionId";
            command.Parameters.AddWithValue("@SessionId", session.SessionId);
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
        public int GetById(string name)
        {
            Connect();
            Session session = new Session();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = $"select sessions.session_id from sessions where time={name}";
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    session.SessionId = Convert.ToInt32(reader.GetValue(0));
                }
            }
            Close();
            return session.SessionId;

        }
    }
}
