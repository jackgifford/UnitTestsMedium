using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestsMedium;

namespace UnitTestsMedium.Tests
{
    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        public void Authenticate_True()
        {
            //Arrange
            var mock = new Mock<IDatabaseRetriever>();
            mock.Setup(x => x.RetrievePassword("user1")).Returns("password");

            //Act
            var login = new Login(mock.Object);
            var isAuthenticate = login.Authenticate("user1", "password");

            //Assert
            Assert.AreEqual(true, isAuthenticate);

        }

        [TestMethod]
        public void Authenticate_False()
        {
            //Arrange
            var mock = new Mock<IDatabaseRetriever>();
            mock.Setup(x => x.RetrievePassword("user1")).Returns("password");

            //Act
            var login = new Login(mock.Object);
            var isAuthenticate = login.Authenticate("user1", "notmypassword");

            //Assert
            Assert.AreEqual(false, isAuthenticate);
        }
    }
}
