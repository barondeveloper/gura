using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Gura.BL;

namespace Test
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public async Task GetAllUsers()
        {
            var userService = new UsersService();
            var users =await userService.GetAll();
        }
    }
}
