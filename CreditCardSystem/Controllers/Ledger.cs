using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardSystem.Controllers
{
    internal class Ledger : IDisposable
    {
        private readonly MainDbContext _context;
        public Ledger()
        {
            _context = new();
        }
        public List<Model.Ledger> GetGeneralLedger(int partyId, DateTime startDate, DateTime endDate)
        {
            try
            {
                return [.. _context
                    .Ledger
                    .Include(x => x.Party)
                    .Include(x => x.Percentage)
                    .Where(x => x.PartyId == partyId && (x.CreationDate >= startDate || x.CreationDate <= endDate))];
            }
            catch 
            {
                return null;
            }
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
