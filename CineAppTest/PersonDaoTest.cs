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
    public class PersonDaoTest
    {
        private PersonDao _dao;
        private MySqlConnection _connection;

        [TestInitialize]
        public void SetUp()
        {
            _connection = new MySqlConnection("Server=localhost;Port=3306;Uid=root;Pwd=T#9758@qlph;Database=cinemapp;");
            _dao = new PersonDao();
            _connection.Open();
        }

        [TestCleanup]
        public void CleanUp()
        {
            _connection.Close();
        }
        [TestMethod]
        public void GetById_ShouldReturnCorrectPersonId_WhenPersonExists()
        {
            // Arrange
            string personName = "John Doe";
            int expectedId = 1;

            // Act
            int actualId = _dao.GetById(personName);

            // Assert
            Assert.AreEqual(expectedId, actualId);
        }


        [TestMethod]
        public void UpdateAndGetByIdTest()
        {
            
            var person = new Person
            {
                PeopleId = 1,
                Name = "John Doe",
                Password = "123456",
                RoleId = 2
            };

            
            _dao.Update(person);
            var updatedPersonId = _dao.GetById(person.Name);
            Assert.AreEqual(person.PeopleId, updatedPersonId);
        }


        [TestMethod]
        public void GetById_ShouldReturnMinusOne_WhenPersonDoesNotExist()
        {
            // Arrange
            string personName = "Nonexistent Person";
            int expectedId = -1;

            // Act
            int actualId = _dao.GetById(personName);

            // Assert
            Assert.AreEqual(expectedId, actualId);
        }
    }
}
