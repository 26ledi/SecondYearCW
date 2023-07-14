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
    public class OrderDaoTest
    {
        private OrderDao _dao;
        private MySqlConnection _connection;

        [TestInitialize]
        public void SetUp()
        {
            _connection = new MySqlConnection("Server=localhost;Port=3306;Uid=root;Pwd=T#9758@qlph;Database=cinemapp;");
            _dao = new OrderDao();
            _connection.Open();
        }

        [TestCleanup]
        public void CleanUp()
        {
            _connection.Close();
        }

        [TestMethod]
        public void GetAllOrderByName_ShouldReturnOrders_WhenNameExists()
        {
            // Arrange
            string name = "John Doe";

            // Act
            var orders = _dao.GetAllOrderByName(name);

            // Assert
            Assert.IsNotNull(orders);
            Assert.IsTrue(orders.Count > 0);
        }

        [TestMethod]
        public void GetAverageByCinemas_ShouldReturnAverageViewers_WhenStartDateAndEndDateProvided()
        {
            // Arrange
            DateTime startDate = new DateTime(2023, 1, 1);
            DateTime endDate = new DateTime(2023, 12, 31);

            // Act
            var averageViewers = _dao.GetAverageByCinemas(startDate, endDate);

            // Assert
            Assert.IsNotNull(averageViewers);
            Assert.IsTrue(averageViewers.Count > 0);
        }

        [TestMethod]
        public void GetPopularFilms_ShouldReturnPopularFilms()
        {
            // Act
            var popularFilms = _dao.GetPopularFilms();

            // Assert
            Assert.IsNotNull(popularFilms);
            Assert.IsTrue(popularFilms.Count > 0);
        }

        [TestMethod]
        public void GetCashiers_ShouldReturnCashiers_WhenStartDateAndEndDateProvided()
        {
            // Arrange
            DateTime startDate = new DateTime(2023, 1, 1);
            DateTime endDate = new DateTime(2023, 12, 31);

            // Act
            var cashiers = _dao.GetCashiers(startDate, endDate);

            // Assert
            Assert.IsNotNull(cashiers);
            Assert.IsTrue(cashiers.Count > 0);
        }
    }
}
