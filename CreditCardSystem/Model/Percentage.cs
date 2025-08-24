using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardSystem.Model
{
    internal class Percentage : BaseEntity
    {
        public decimal Value { get; set; } = default!;
    }
}
