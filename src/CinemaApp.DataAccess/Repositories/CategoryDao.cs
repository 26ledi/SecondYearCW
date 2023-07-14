using CinemaApp.DataAccess.Entities;
using MySql.Data.MySqlClient;
namespace CinemaApp.DataAccess.Repositories;

public class CategoryDao
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
        {
            throw ex;
        }
    }
    public void Insert(Category category)
    {
        MySqlCommand command = new MySqlCommand();
        command.Connection = connection;
        command.CommandText = "INSERT INTO categories (category_id,name) VALUES (@CategoryId,@Name)";
        command.Parameters.AddWithValue("@CategoryId", category.CategoryId);
        command.Parameters.AddWithValue("@Name", category.Name);


        try
        {
            Connect();
            command.ExecuteNonQuery();// méthode ExecuteNonQuery() est utilisée pour exécuter une commande SQL
                                      
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
    public List<Category> GetAll()
    {
        List<Category> list = new List<Category>();
        Connect();
        MySqlCommand command = new MySqlCommand();
        command.Connection = connection;
        command.CommandText = "select category_id,name from categories";
        var reader = command.ExecuteReader();
        if (reader.HasRows)
        {
            while (reader.Read())
            {
                Category category = new Category();
                category.CategoryId = Convert.ToInt32(reader.GetValue(0));
                category.Name = reader.GetValue(1).ToString();
               
                list.Add(category);
            }
        }
        Close();
        return list;
    }


    public void Update(Category category)
    {
        MySqlCommand command = new MySqlCommand();
        command.Connection = connection;
        command.CommandText = "UPDATE categories SET name = @Name WHERE category_id = @CategoryId";
        command.Parameters.AddWithValue("@CategoryId", category.CategoryId);
        command.Parameters.AddWithValue("@Name", category.Name);

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

    public void Delete(Category categoryId)
    {
        MySqlCommand command = new MySqlCommand();
        command.Connection = connection;
        command.CommandText = "DELETE FROM categories WHERE category_id = @CategoryId";
        command.Parameters.AddWithValue("@CategoryId", categoryId);
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
        Category category = new Category();
        MySqlCommand command = new MySqlCommand();
        command.Connection = connection;
        command.CommandText = $"select categories.category_id from categories where name={name}";
        var reader = command.ExecuteReader();
        if (reader.HasRows)
        {
            while (reader.Read())
            {
                category.CategoryId = Convert.ToInt32(reader.GetValue(0));
            }
        }
        Close();
        return category.CategoryId;

    }
}

