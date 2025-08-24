using CreditCardSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardSystem.Controllers
{
    internal class Percent : IDisposable
    {
        private readonly MainDbContext _context;
        public Percent()
        {
            _context = new();
        }
        public List<Percentage> GetPercentages()
        {
            try
            {
                return _context.Percentages.ToList();
            }
            catch 
            {
                return new();
            }
        }
        public bool AddPercentage(decimal value, string description)
        {
            try
            {
                var percentage = new Percentage
                {
                    Value = value,
                    Remarks = description,
                    CreationDate = DateTime.Now
                };
                _context.Percentages.Add(percentage);
                _context.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public bool UpdatePercentage(int id, decimal value, string description)
        {
            try
            {
                var percentage = _context.Percentages.FirstOrDefault(p => p.Id == id);
                if (percentage != null)
                {
                    percentage.Value = value;
                    percentage.Remarks = description;
                    _context.SaveChanges();
                    return true;
                }
                return false;
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

        public Percentage GetSingle(int id)
        {
            try
            {
                return _context.Percentages.FirstOrDefault(x => x.Id == id);
            }
            catch 
            {
                return null;
            }
        }
    }
}
