using CinemaApp.DataAccess.Entities;
using MySql.Data.MySqlClient;

namespace CinemaApp.DataAccess.Repositories;

public class PersonDao
{
 
   MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Uid=root;Pwd=T#9758@qlph;Database=cinemapp;");
    public void Connect()
    {
        try
        {
            connection.Open();
        }
        catch(ArgumentNullException)
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
    /// <summary>
    /// Function for Adding User's Data into the database
    /// </summary>
    /// <returns></returns>
    public void Insert(Person people)
    {
        Connect();
        MySqlCommand command = new MySqlCommand();
        command.Connection = connection;
        command.CommandText = "INSERT INTO people (people_id,name,password,role_id) VALUES (@PeopleId,@name,@Password,@RoleId)";
        command.Parameters.AddWithValue("@PeopleId",people.PeopleId);
        command.Parameters.AddWithValue("@name", people.Name);
        command.Parameters.AddWithValue("@Password", people.Password);
        command.Parameters.AddWithValue("@RoleId", people.RoleId);
        command.ExecuteNonQuery();
        Close();

    }
    /// <summary>
    /// Read From the Data Base
    /// </summary>
    /// <returns></returns>
    public virtual List<Person> GetAll()
    {
        List<Person> list = new List<Person>();

        Connect();

        MySqlCommand command = new MySqlCommand();
        command.Connection = connection;
        command.CommandText = "select people_id,name,password,role_id from people;";

        var reader = command.ExecuteReader();//for reading in the data base

        if (reader.HasRows)//if there is rows
        {
            while(reader.Read())
            {
                Person people = new Person();
                people.PeopleId = Convert.ToInt32(reader.GetValue(0));
                people.Name = reader.GetValue(1).ToString();
                people.Password = reader.GetValue(2).ToString();
                people.RoleId = Convert.ToInt32(reader.GetValue(3));

                list.Add(people);
            }
        }

        Close();
        return list;
    }
    /// <summary>
    /// Update The Database 
    /// </summary>
    /// <param name="people"></param>
    public void Update(Person people)
    {
        MySqlCommand command = new MySqlCommand();
        command.Connection = connection;
        command.CommandText = "UPDATE people SET name=@name,password=@Password,role_Id=@RoleId WHERE people_id=@PeopleId";
        command.Parameters.AddWithValue("@PeopleId",people.PeopleId);
        command.Parameters.AddWithValue("@name", people.Name);
        command.Parameters.AddWithValue("@Password", people.Password);
        command.Parameters.AddWithValue("@RoleId", people.RoleId);
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
    /// Delete Element From the Data Base
    /// </summary>
    /// <param name="people"></param>
    public void Delete(Person people)
    {
        Connect();
        MySqlCommand command = new MySqlCommand();
        command.Connection = connection;
        command.CommandText = "DELETE FROM people Where people_id=@PeopleId";
        command.Parameters.AddWithValue("@PeopleId", people.PeopleId);
        command.ExecuteNonQuery();
        Close();
        
    }
    public int GetById(string name)
    {
    Connect();
    MySqlCommand command = new MySqlCommand();
    command.Connection = connection;
    command.CommandText = $"SELECT people_id FROM people WHERE name='{name}'";
    int? result = (int?)command.ExecuteScalar();
    Close();
    return result ?? -1; // -1 pour indiquer que la personne n'a pas été trouvée
    }
   

}
