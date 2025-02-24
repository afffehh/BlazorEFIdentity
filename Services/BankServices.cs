using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorEFIdentity.Data;
using BlazorEFIdentity.Models;
using System.Security.Principal;

namespace BlazorEFIdentity.Services
{
    public class BankServices
    {
        public readonly ApplicationDbContext _context;

        public BankServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateAccountAsync(string userId, string accountName, string accountType)
        {
            var newAccount = new Account
            {
                UserId = userId,
                AccountNumber = Guid.NewGuid().ToString(),
                Name = accountName,
                Balance = 0,
                AccountType = accountType,
                IsActive = true,
                CardNumber = Guid.NewGuid().ToString()
            };

            _context.Accounts.Add(newAccount);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task CreateTransactionAsync(int toAccountId, int fromAccountId, decimal amount, string message)
        {
            var fromAccount = await _context.Accounts.FindAsync(fromAccountId);

            var newTransaction = new Transactions
            {

                ToAccount = "hej",
                FromAccountId = fromAccountId,
                ClosingBalance = fromAccount.Balance - amount,
                Currency = "KR",
                IsReserved = false,
                Message = message,
                TransactionNumber = Guid.NewGuid().ToString()

            };
            _context.Transactions.Add(newTransaction);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Transactions>> GetTransactionsByUserAsync(int accountId)
        {
            return await _context.Transactions
                .Include(t => t.FromAccount)
                .ThenInclude(a => a.User)
                .Where(t => t.FromAccountId == accountId).ToListAsync();
        }
        public async Task<List<Account>> GetAccountsAsync(string userId)
        {
            return await _context.Accounts.Where(a => a.UserId == userId).ToListAsync();
        }

        public async Task<bool> DeleteAccountAsync(int accountId, string userId)
        {
            var account = await _context.Accounts.FirstOrDefaultAsync(a => a.Id == accountId && a.UserId == userId);
            if (account == null) return false;

            _context.Accounts.Remove(account);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
