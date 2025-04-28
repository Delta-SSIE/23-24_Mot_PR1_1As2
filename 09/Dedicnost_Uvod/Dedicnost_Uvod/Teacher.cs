using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedicnost_Uvod
{
    //Dědí z třídy Human
    internal class Teacher : Human
    {

        public string[] subjects { get; set; }
        public int cislo_kab { get; set; }

        public void Teaching()
        {
            Console.WriteLine($"{name} teach:");
            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine(subjects[i]);
            }
        }
    }
}
