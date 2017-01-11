using Gura.Dal;
using Gura.Dal.Repositories;
using Gura.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gura.BL
{
    public class UsersService
    {
        private UsersRepository usersRepository;
        public UsersService()
        {
            usersRepository = new UsersRepository(new thedevelopmentstore_guraEntities());
        }

        public async Task<List<UserModel>> GetAll()
        {
            var users = await usersRepository.GetAllAsync();
            var userList = users.Select(u => new UserModel
            {
                Id = u.Id,
                Email = u.Email,
                Password = u.Password,
                IsActive = u.IsActive,
                FirstName=u.FirstName,
                LastName=u.LastName,
                MobilePhone=u.MobilePhone,
                Phone=u.Phone
            }).ToList();

            return userList;

        }
    }
}
