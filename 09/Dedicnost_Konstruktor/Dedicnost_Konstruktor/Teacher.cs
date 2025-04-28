using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedicnost_Uvod
{
    //Dědí z třídy Human
    internal class Teacher :Human
    {

        public string[] subjects { get; set; }
        public int cislo_kab { get; set; }

        //vše co posílám konstruktoru rodičovské třídy musí být zapsáno v ": base(par1, par2)"
        public Teacher(string jmeno, int vek, string[] predmety, int cislo) : base(jmeno, vek)
        {
            subjects = predmety;
            cislo_kab = cislo;
        }

        public void Teaching()
        {
            Console.WriteLine($"teach:");
            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine(subjects[i]);
            }
        }
    }
}
