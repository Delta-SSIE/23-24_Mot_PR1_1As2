using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakce_Uvod
{
    //Třída Student dědí všechny vlastnosti a metody ze třídy Human
    //Lze dědit z více tříd zároven...
    internal class Student : Human
    {
       public string grade { get; set; }
        public int[] mark { get; set; }

        //vše co posílám konstruktoru rodičovské třídy musí být zapsáno v ": base(par1, par2)"
        public Student(string j, int v, string t, int[] z) : base(j,v)
        {
            grade = t;
            mark = z;
        }

        //override metoda přepisuje virtual metodu danou třídou rodičovskou (HUMAN)
        public override void IdentifySelf()
        {
            bool pomoc = (age >= 18) ? true : false;
            Console.WriteLine($"student: {name} : {pomoc}");
        }

        public override void Talk()
        {
            Console.WriteLine("Bla bla");
        }
    }
}
