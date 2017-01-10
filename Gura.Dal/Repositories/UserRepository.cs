using Catel.Data.Repositories;
using Gura.Interfaces.Repositories;
using Gura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gura.Dal.Repositories
{
    public class UsersRepository : EntityRepositoryBase<User, int>, IUserRepository
    {

        public UsersRepository(DbContext dbContext)
            : base(dbContext) { }


        public User GetByID(int ID)
        {
            var item = this.Find(p => p.ID == ID).SingleOrDefault();
            return item;

        }

        public User GetUserByEmailAndPassword(string email, string password)
        {
            User user = this.Find(u => u.Email == email && u.Password == password && u.IsActive).SingleOrDefault();
            return user;
        }

        //public Dictionary<int, string> ToDictionary()
        //{
        //    var dictionary = this.Get().ToDictionary(r => r.ID, r => r.Title + " " + r.FirstName + " " + r.LastName);
        //    return dictionary;
        //}


    }
}
