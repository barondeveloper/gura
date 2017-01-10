using Gura.Models;
using Catel.Data.Repositories;

namespace Gura.Interfaces.Repositories
{
    public interface IUserRepository : IEntityRepository<User, int>
    {
        User GetByID(int ID);
        User GetUserByEmailAndPassword(string email, string password);
    }
}
