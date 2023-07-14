using CinemaApp.DataAccess.Entities;
using MySql.Data.MySqlClient;

namespace CinemaApp.DataAccess.Repositories;

public class CinemaOrderDao
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
    public List<CinemaOrder> GetAll()
    {
        List<CinemaOrder> list = new List<CinemaOrder>();
        Connect();
        MySqlCommand command = new MySqlCommand();
        command.Connection = connection;
        command.CommandText = "select cinemaorder_id,cinema_id,film_id from cinema_order";
        var reader = command.ExecuteReader();
        if (reader.HasRows)
        {
            while (reader.Read())
            {
                CinemaOrder cinemaOrder = new CinemaOrder();
                cinemaOrder.CinemaOrderId= Convert.ToInt32(reader.GetValue(0));
                cinemaOrder.CinemaId = Convert.ToInt32(reader.GetValue(1));
                cinemaOrder.FilmId = Convert.ToInt32(reader.GetValue(2));


                list.Add(cinemaOrder);
            }
        }

        Close();
        return list;
    }


}
