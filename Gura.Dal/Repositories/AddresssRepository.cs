using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gura.Dal.Repositories
{
    public class AddresssRepository : EntityBaseRepository<Address>
    {
        public AddresssRepository(thedevelopmentstore_guraEntities dbContext)
            : base(dbContext) { }

        public async Task<Address> GetByID(int ID)
        {
            return await this.GetSingleAsync(u => u.Id == ID);

        }

        public async Task<IEnumerable<Address>> GetAddressByUser(int userId)
        {
            return await this.WhereAsync(u => u.UserId==userId);
        }

        //public Dictionary<int, string> ToDictionary()
        //{
        //    var dictionary = this.Get().ToDictionary(r => r.ID, r => r.Title + " " + r.FirstName + " " + r.LastName);
        //    return dictionary;
        //}


    }
}
