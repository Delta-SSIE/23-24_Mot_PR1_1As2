using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop
{
    abstract class Item : IDisplay
    {
        public string name { get; set; }
        public double price { get; set; }
        public string type { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name {name}, price {price}");
        }
    }
}
