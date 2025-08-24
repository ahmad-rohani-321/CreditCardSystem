using CreditCardSystem.Model;
using DevExpress.Charts.Native;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CreditCardSystem.Controllers
{
    internal class Parties : IDisposable
    {
        private readonly MainDbContext _context;
        public Parties()
        {
            _context = new();
        }
        public List<Party> GetParties()
        {
            try
            {
                return [.. _context.Parties];
            }
            catch 
            {
                return new List<Party>();
            }
        }
        public List<Party> GetActiveParties()
        {
            try
            {
                return [.. _context.Parties.Where(x => x.IsActive)];
            }
            catch 
            {
                return null;
            }
        }
        public List<Party> GetParties(params string[] partyType)
        {
            try
            {
                return [.. _context.Parties.Where(x => partyType.Contains(x.PartyType))];
            }
            catch 
            {
                return [];
            }
        }
        public Party GetPartyById(int id)
        {
            try
            {
                return _context.Parties.FirstOrDefault(p => p.Id == id);
            }
            catch 
            {
                return new();
            }
        }
        public bool AddParty(Party party, decimal firstBalance)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var addedParty = _context.Add(party);
                    _context.SaveChanges();
                    if (firstBalance > 0)
                    {
                        Model.Ledger ledger = new()
                        {
                            PartyId = party.Id,
                            TransactionType = Defaults.DefaultTransactionTypes[3],
                            Remarks = "",
                            PercentageId = 1,
                            CreationDate = DateTime.Now,
                            Debit = firstBalance,
                            Balance = firstBalance
                        };

                        _context.Add(ledger);
                    }
                    else
                    {
                        Model.Ledger ledger = new()
                        {
                            PartyId = party.Id,
                            TransactionType = Defaults.DefaultTransactionTypes[3],
                            Remarks = "",
                            PercentageId = 1,
                            CreationDate = DateTime.Now,
                            Credit = firstBalance,
                            Balance = 0 - firstBalance
                        };

                        _context.Add(ledger);
                    }
                        _context.SaveChanges();
                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }
        public bool UpdateParty(Party party)
        {
            try
            {
                var existingParty = _context.Parties.FirstOrDefault(p => p.Id == party.Id);
                if (existingParty != null)
                {
                    existingParty.Name = party.Name;
                    existingParty.PartyType = party.PartyType;
                    existingParty.Remarks = party.Remarks;
                    _context.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ChangeActivation(int id)
        {
            var party = _context.Parties.FirstOrDefault(p => p.Id == id);
            if (party != null)
            {
                party.IsActive = !party.IsActive;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
