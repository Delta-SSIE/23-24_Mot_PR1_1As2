using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uvod_OOP_sam
{
    internal class Lide
    {
        public string name;
        public int age;
        public Lide(string jmeno, int vek) //konstruktor s dvěma parametry
        {
            this.name = jmeno;
            this.age = vek;
        }
        

        public void Introduction()
        {
            Console.WriteLine($"Hello, I'm {this.name} and I'm {this.age} years old!");
        }
    }
}
