using CinemaApp.DataAccess.Entities;
using CinemaApp.DataAccess.Repositories;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineAppTest
{
    [TestClass]
    public class FilmDaoTest
    {
        private MySqlConnection _connection;
        private FilmDao _filmDao;

        [TestInitialize]
        public void Setup()
        {
            string connectionString = "Server=localhost;Port=3306;Uid=root;Pwd=T#9758@qlph;Database=cinemapp;";
            _connection = new MySqlConnection(connectionString);
            _filmDao = new FilmDao();
        }

        [TestMethod]
        public void GetAll_ShouldReturnAllFilmsFromDatabase()
        {
            // Act
            List<Film> films = _filmDao.GetAll();

            // Assert
            Assert.IsNotNull(films);
            Assert.IsTrue(films.Count > 0);
        }

        [TestMethod]
        public void Update_ShouldUpdateFilmInDatabase()
        {
            // Arrange
            Film film = new Film
            {
                FilmId = 1,
                Name = "Updated Film",
                Duration = 150.0,
                Rating = 4.2,
                Imagebytes = new byte[] { /* updated image bytes */ },
                Price = 12.0,
                Diffusion = DateTime.Now.AddDays(7)
            };

            // Act
            _filmDao.Update(film);

            // Assert
            string selectQuery = "SELECT name, duration, rating, image, price, diffusion FROM films WHERE film_id = 1";
            using (MySqlCommand command = new MySqlCommand(selectQuery, _connection))
            {
                _connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    Assert.IsTrue(reader.Read());

                    Assert.AreEqual("Updated Film", reader.GetString(0));
                    Assert.AreEqual(150.0, reader.GetDouble(1));
                    Assert.AreEqual(4.2, reader.GetDouble(2));
                    // Assert the remaining properties...

                    _connection.Close();
                }
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            _connection.Dispose();
            _filmDao = null;
        }
    }

}
