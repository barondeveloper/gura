using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Gura.BL;

namespace Tests
{
    [TestClass]
    public class UsersTests
    {
        [TestMethod]
        public async Task GetAllUsers() 
        {
            var us = new UsersService();
            var users = await us.GetAll();
            Assert.AreNotEqual(users, null);
        }
    }
}
