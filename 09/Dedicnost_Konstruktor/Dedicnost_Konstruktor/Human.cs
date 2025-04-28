using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedicnost_Uvod
{
    internal class Human
    {
        public string name { get; set; }
        public int age { get; set; }

        public Human(string jmeno, int vek)
        {
            name = jmeno;
            age = vek;
        }

        //virtual znamená, že metoda půjde u tříd, co z této dědí přepsat
        public virtual void IdentifySelf()
        {
            Console.WriteLine($"{name} : {age}");
        }
    }
}
