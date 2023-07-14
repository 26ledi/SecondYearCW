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
    public class CinemaDaoTest
    {
        private CinemaDao _dao;
        private MySqlConnection _connection;

        [TestInitialize]
        public void SetUp()
        {
            _connection = new MySqlConnection("Server=localhost;Port=3306;Uid=root;Pwd=T#9758@qlph;Database=cinemapp;");
            _dao = new CinemaDao();
            _connection.Open();
        }

        [TestCleanup]
        public void CleanUp()
        {
            _connection.Close();
        }

        [TestMethod]
        public void GetAll_ShouldReturnAllCinemas_FromDatabase()
        {
            // Act
            var cinemas = _dao.GetAll();

            // Assert
            Assert.IsNotNull(cinemas);
            Assert.IsTrue(cinemas.Count > 0);
        }


        [TestMethod]
        public void GetAll_ShouldReturnAllExistingCinemas_FromDatabase()
        {
            // Arrange


            // Act
            var cinemas = _dao.GetAll();

            // Assert
            Assert.IsNotNull(cinemas);
            Assert.IsTrue(cinemas.Count > 0);

        }

    }
}
