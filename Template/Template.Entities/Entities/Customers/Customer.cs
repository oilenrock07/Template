using Template.Entities.Entities.Accounts;

namespace Template.Entities.Entities.Customers
{
    public class Customer
    {
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public User Identity { get; set; } 
        public string Location { get; set; }
        public string Locale { get; set; }
        public string Gender { get; set; }
    }
}
