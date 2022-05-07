using E_Pharma_App;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace E_Pharma_App.Tests
{
    [TestClass()]
    public class LoginTest1
    {
        /// <summary>
        /// Checks for the valid user login 
        /// </summary>
        [TestMethod()]
        public void TestGoodLogin()
        {
            //Arrange
            User user = new User();
            Assert.AreEqual(true, user.Login12("as", "sa"));            
        }
        /// <summary>
        /// Checks for the Invalid User login
        /// </summary>
        [TestMethod()]
        public void TestBadLogin()
        {
            //Arrange
            User user = new User();
            Assert.AreEqual(false, user.Login12("as", "saaa"));


        }
    }
}

