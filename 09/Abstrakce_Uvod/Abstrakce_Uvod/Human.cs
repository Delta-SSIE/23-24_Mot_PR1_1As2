using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakce_Uvod
{
    //Abstraktní třída je pouze pro dědičnost jiných tříd
    abstract class Human
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

        //abstraktní metoda - tato metoda musí být v jiných odvozených třídách definována
        public abstract void Talk();
    }
}
