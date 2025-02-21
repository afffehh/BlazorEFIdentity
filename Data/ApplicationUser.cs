using BlazorEFIdentity.Models;
using Microsoft.AspNetCore.Identity;

namespace BlazorEFIdentity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? Handle { get; set; }
        public string PersonalNumber { get; set; }
        public string Adress { get; set; }
        public List<Account> Accounts { get; set; } = new List<Account>();

    }
}
