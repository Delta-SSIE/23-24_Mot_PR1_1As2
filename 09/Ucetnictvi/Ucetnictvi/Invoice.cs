using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucetnictvi
{
    abstract class Invoice
    {
        public string CustomerName { get; set; }

        public abstract double CalculateTotal();

        public virtual string GetDetails()
        {
            return $"{CustomerName} bill";
        }

        public Invoice(string name)
        {
            CustomerName = name;
        }

    }
}
