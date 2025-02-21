using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorEFIdentity.Data;
using BlazorEFIdentity.Models;

namespace BlazorEFIdentity.Services
{
    public class BankServices
    {
        private readonly ApplicationDbContext _context;

        public BankServices(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
