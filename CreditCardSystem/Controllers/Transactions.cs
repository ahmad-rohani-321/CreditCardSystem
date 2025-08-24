using System;
using System.Linq;

namespace CreditCardSystem.Controllers
{
    internal class Transactions : IDisposable
    {
        private readonly MainDbContext _context;
        public Transactions()
        {
            _context = new();
        }
        public bool AddTransaction(int fromId, int toId, decimal balance, string remarks, int transactionType, int cashType, DateTime date, string phoneNumber)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    decimal fromLastBalance = GetLastBalance(fromId);
                    decimal toLastBalance = GetLastBalance(toId);
                    int percentageId = _context.Percentages.OrderByDescending(x => x.Id).FirstOrDefault().Id;

                    // first entry 
                    Model.Ledger firstEntry = new Model.Ledger()
                    {
                        CreationDate = date,
                        PercentageId = percentageId,
                        TransactionType = Defaults.DefaultTransactionTypes[transactionType],
                        Remarks = remarks,
                        PartyId = fromId,
                        PhoneNumber = phoneNumber
                    };

                    // Second Entry
                    Model.Ledger secondEntry = new Model.Ledger()
                    {
                        CreationDate = date,
                        PercentageId = percentageId,
                        TransactionType = Defaults.DefaultTransactionTypes[transactionType],
                        Remarks = remarks,
                        PartyId = toId,
                        PhoneNumber = phoneNumber
                    };

                    // manage debit and credit
                    switch (transactionType)
                    {
                        // sale, purchase, transfar
                        case 0:
                        case 1:
                        case 2:
                            firstEntry.Debit = balance;
                            firstEntry.Balance = fromLastBalance - balance;
                            _context.Add(firstEntry);

                            secondEntry.Credit = balance;
                            secondEntry.Balance = toLastBalance + balance;
                            _context.Add(secondEntry);
                            break;

                        // cash
                        case 3:

                            
                            // 0 credit 
                            if (cashType == 0)
                            {
                                secondEntry.Credit = balance;
                                secondEntry.Balance = toLastBalance + balance;
                            }
                            else
                            {
                                secondEntry.Debit = balance;
                                secondEntry.Balance = toLastBalance - balance;
                            }
                                // 1 debit
                            _context.Add(secondEntry);
                            break;
                    }
                    // get account to manage balance 
                    _context.Parties.SingleOrDefault(x => x.Id == fromId).Balance = firstEntry.Balance;
                    _context.Parties.SingleOrDefault(x => x.Id == toId).Balance = secondEntry.Balance;

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
        public decimal GetLastBalance(int id)
        {
            try
            {
                Model.Ledger ledger = _context.Ledger
                    .Where(x => x.PartyId == id)
                    .OrderByDescending(x => x.Id)
                    .FirstOrDefault();
                if (ledger != null) return ledger.Balance;
                else return 0M;
            }
            catch
            {
                return 0M;
            }
        }
        /// <summary>
        /// Allows user to add transactions after checking parties and percentages
        /// </summary>
        public bool IsAllowed()
        {
            try
            {
                int countOfParties = _context.Parties.Count(x => x.IsActive);
                int countOfPercent = _context.Percentages.Count();
                return countOfParties > 0 && countOfPercent > 0;
            }
            catch
            {
                return false;
            }
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
