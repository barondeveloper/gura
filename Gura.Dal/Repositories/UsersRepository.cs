using System.Threading.Tasks;

namespace Gura.Dal.Repositories
{
    public class UsersRepository : EntityBaseRepository<User>
    {

        public UsersRepository(thedevelopmentstore_guraEntities dbContext)
            : base(dbContext) { }

        public async Task<User> GetByID(int ID)
        {
            return await this.GetSingleAsync(u => u.Id == ID);

        }

        public async Task<User> GetUserByEmailAndPassword(string email, string password)
        {
            return await this.GetSingleAsync(u => u.Email == email && u.Password == password && u.IsActive);
        }

        //public Dictionary<int, string> ToDictionary()
        //{
        //    var dictionary = this.Get().ToDictionary(r => r.ID, r => r.Title + " " + r.FirstName + " " + r.LastName);
        //    return dictionary;
        //}


    }
}
