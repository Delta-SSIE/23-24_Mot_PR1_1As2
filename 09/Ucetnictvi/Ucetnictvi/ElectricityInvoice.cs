using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucetnictvi
{
    internal class ElectricityInvoice : Invoice
    {
        public double kWhUsed { get; set; }
        public double PricePerkWh { get; set; }
        public override double CalculateTotal()
        {
            return kWhUsed * PricePerkWh;
        }

        public ElectricityInvoice(string name, double used) : base(name)
        {
            PricePerkWh = 5;
            kWhUsed = used;
        }
    }
}
