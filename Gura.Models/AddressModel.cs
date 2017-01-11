namespace Gura.Models
{
    public  class AddressModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string StreetName { get; set; }
        public string HouseNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ApartmentNumber { get; set; }
        public int Type { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }

        public virtual UserModel User { get; set; }
    }
}
