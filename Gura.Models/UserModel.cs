using System.Collections.Generic;

namespace Gura.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
 
        public virtual List<AddressModel> Addresses { get; set; }
    }
}
