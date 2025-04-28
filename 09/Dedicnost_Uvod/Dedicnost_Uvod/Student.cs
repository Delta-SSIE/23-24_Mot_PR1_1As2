using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedicnost_Uvod
{
    //Třída Student dědí všechny vlastnosti a metody ze třídy Human
    //Lze dědit z více tříd zároven...
    internal class Student : Human
    {
       public string grade { get; set; }
        public int[] mark { get; set; }
    }
}
