using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VozovyPark
{
    internal class Prodejce
    {
        public string Jmeno;
        public int[] IndexyAut;

        //Konstruktor
        public Prodejce (string j)
        {
            Jmeno = j;
            IndexyAut = new int[0];
        }

        public void VypisAuta(Vozidlo[] auta)
        {
            for (int i = 0; i < IndexyAut.Length; i++)
            {
                auta[IndexyAut[i]].VypisInfo();
            }
        }
    }
}
