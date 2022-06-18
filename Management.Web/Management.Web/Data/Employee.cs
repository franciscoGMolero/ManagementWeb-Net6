using Microsoft.AspNetCore.Identity;

namespace Management.Web.Data
{
    public class Employee : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? TaxId { get; set; }
        public DateTime DateOfBirthday { get; set; }
        public DateTime DataJoined { get; set; }

    }
}
