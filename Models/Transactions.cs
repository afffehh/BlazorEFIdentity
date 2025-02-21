namespace BlazorEFIdentity.Models
{
    public class Transactions
    {

        public int Id { get; set; }
        public string ToAccount { get; set; }
        public Account FromAccount { get; set; }
        public int FromAccountId { get; set; }
        public DateTime DateTime { get; set; } = DateTime.UtcNow;
        public decimal ClosingBalance { get; set; }
        public string Currency { get; set; }
        public string Reserved { get; set; }
        public string Message { get; set; }
        public string TransactionNumber { get; set; }
    }
}
