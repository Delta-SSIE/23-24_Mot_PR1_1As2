using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucetnictvi
{
    internal class InternetInvoice : Invoice
    {
       public double FlatRate { get; set; } 
       public int DataUsedGB { get; set; }
       public double DataOverLimitFeePerGB { get; set; }

        public override double CalculateTotal()
        {
            double price = 0;
            if(DataUsedGB > 100)
            {
                price = FlatRate * 100;
                price += (DataUsedGB - 100) * DataOverLimitFeePerGB;
            } else
            {
                price = FlatRate * DataUsedGB;
            }
            return price;
        }

        public InternetInvoice(string name, int data) : base(name)
        {
            DataUsedGB = data;
            FlatRate = 1;
            DataOverLimitFeePerGB = 3;
        }
    }
}
