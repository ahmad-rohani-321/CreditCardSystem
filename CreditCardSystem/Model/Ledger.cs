using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardSystem.Model
{
    internal class Ledger : BaseEntity
    {
        public string TransactionType { get; set; } = default!;
        public string PhoneNumber { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal Balance { get; set; }
        public decimal Percentage { get; set; }
        // Foreign Keys

        public int PartyId { get; set; }

        [ForeignKey(nameof(PartyId))]
        public Party Party { get; set; }


    }
}
