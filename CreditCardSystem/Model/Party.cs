using System.Collections.Generic;

namespace CreditCardSystem.Model
{
    internal class Party : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string PartyType { get; set; } = default!;
        public bool IsActive { get; set; } = true;
        public bool IsEditable { get; set; } = true;
        public decimal Balance { get; set; }
        public List<string> PhoneNumbers { get; set; } = new List<string>();
    }
}
