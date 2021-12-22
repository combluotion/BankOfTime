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
            _context = new masterEntities(Effort.EntityConnectionFactory.CreateTransient("name=masterEntities"),true);
        }

        [TestCleanup]
        public void finishTests()
        {
            _context.Dispose();
        }

        [TestMethod]
        public void LoginTestOk() //Comprobar un login correcto de un usuario registrado
        {
            //Creo usuario
            user newUser = new user();
            newUser.MobilePhone = "777777777";
            newUser.Password = "777777777";
            _context.user.Add(newUser);
            _context.SaveChanges();
            //Hago login
            Login loginTest = new Login(_context);
            bool loginResponse = loginTest.TryLogin(newUser.MobilePhone, newUser.Password);
            //Assert
            Assert.IsTrue(loginResponse);
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
            user newUser = new user();
            newUser.MobilePhone = "888888888";
            newUser.Password = "888888888";
            newUser.Balance = 20;

            petition newPetiton = new petition();
            newPetiton.Status = (int?)PetitionStatus.status.pending;
            newPetiton.Requester = newUser.MobilePhone;

            _context.user.Add(newUser);
            _context.petition.Add(newPetiton);
            _context.SaveChanges();

            ConsolidatePetition con = new ConsolidatePetition(newPetiton.Id, _context);
            con.ConsolidatePetitionCall(newPetiton.Id, "Test", DateTime.Now, 10);

            Assert.AreEqual(newUser.Balance, 10);

        }

        [TestMethod]
        public void EmptyBalanceCheck() //Comprobar que no se pueda consolidar una petición sin balance suficiente
        {
            user newUser = new user();
            newUser.MobilePhone = "888888888";
            newUser.Password = "888888888";
            newUser.Balance = 0;

            petition newPetiton = new petition();
            newPetiton.Status = (int?)PetitionStatus.status.pending;
            newPetiton.Requester = newUser.MobilePhone;

            _context.user.Add(newUser);
            _context.petition.Add(newPetiton);
            _context.SaveChanges();

            ConsolidatePetition con = new ConsolidatePetition(newPetiton.Id, _context);
            

            Assert.IsFalse(con.ConsolidatePetitionCall(newPetiton.Id, "Test", DateTime.Now, 10));
        }


    }
}
