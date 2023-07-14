using CinemaApp.DataAccess.Entities;
using MySql.Data.MySqlClient;

namespace CinemaApp.DataAccess.Repositories
{
    public class RoleDao
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
            catch(InvalidOperationException ex) 
            {
                throw ex;
            }
        }
        /// <summary>
        /// Function for creating
        /// </summary>
        /// <param name="Role"></param>
        public void Insert(Role role)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO roles (role_id,role_name) VALUES (@role_Id,@role_name)";
            command.Parameters.AddWithValue("@role_Id", role.RoleId);
            command.Parameters.AddWithValue("@role_name", role.Rolename);

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
        /// Function for reading from the data base
        /// </summary>
        /// <returns></returns>
        public List<Role> GetAll() 
        {
            List<Role> list = new List<Role>();
            Connect();
            MySqlCommand command = new MySqlCommand();
            command.Connection= connection;
            command.CommandText = "select role_id,role_name from roles";

            var reader= command.ExecuteReader();

            if (reader.HasRows) 
            {
                while(reader.Read()) 
                {
                    Role role = new Role();
                    role.RoleId= Convert.ToInt32(reader.GetValue(0));
                    role.Rolename= reader.GetValue(1).ToString();
                    list.Add(role);
                }
               
            }
            Close();
            return list;
        }
        /// <summary>
        /// Function for Updating
        /// </summary>
        /// <param name="role"></param>
        public void Update(Role role) 
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE roles SET role_name=@Rolename WHERE role_id=@RoleId";
            command.Parameters.AddWithValue("@RoleId", role.RoleId);
            command.Parameters.AddWithValue("@Rolename", role.Rolename);
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
        public void Delete(Role role)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM roles Where role_id=@RoleId";
            command.Parameters.AddWithValue("@RoleId", role.RoleId);
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
        
    }
}
