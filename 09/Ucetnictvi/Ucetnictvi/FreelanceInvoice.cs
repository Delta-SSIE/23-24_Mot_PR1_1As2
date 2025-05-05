using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucetnictvi
{
    internal class FreelanceInvoice :Invoice
    {
        public double HoursWorked { get; set; }
        public double RatePerHour { get; set; }

        public override double CalculateTotal()
        {
            return HoursWorked * RatePerHour;
        }

        public FreelanceInvoice(string name, double hours) : base(name)
        {
            HoursWorked = hours;
            RatePerHour = 124;
        }
    }
}
