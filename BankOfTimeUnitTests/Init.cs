using BankOfTime;
using BankOfTime.Models;
using Effort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankOfTimeUnitTests
{
    [TestClass]
    public class Init
    {

        private masterEntities _context;

        [TestInitialize]
        public void Initialize()
        {
            _context = new masterEntities(Effort.EntityConnectionFactory.CreateTransient("name=masterEntities"));
        }

        [TestMethod]
        public void LoginTestOk() //Comprobar un login correcto de un usuario registrado
        {
            //Creo usuario

            //Hago login

            //Assert

        }

        [TestMethod]
        public void LoginTestKo() //Comprobar un login incorrecto de un usuario no registrado
        {
            Login loginTest = new Login(_context);
            bool loginResponse = loginTest.TryLogin("666666666", "666666666");

            Assert.IsFalse(loginResponse);
        }

        [TestMethod]
        public void BalanceCheck() //Comprobar disminución correcta del balance de un usuario
        {
        }

        [TestMethod]
        public void EmptyBalanceCheck() //Comprobar que no se pueda consolidar una petición sin balance suficiente
        {
        }

    }
}
