using BlazorEFIdentity.Data;

namespace BlazorEFIdentity.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public string AccountType { get; set; }
        public List<Transactions> Transactions { get; set; } = new List<Transactions>();
        public bool IsActive { get; set; }
        public string CardNumber { get; set; }
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }

    }
}
