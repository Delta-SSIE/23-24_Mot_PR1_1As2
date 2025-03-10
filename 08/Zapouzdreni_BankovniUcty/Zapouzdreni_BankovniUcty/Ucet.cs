using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapouzdreni_BankovniUcty
{
    internal class Ucet
    {
        //auto get a set
        public string JmenoVlastnika { get; set; }

        //Soukromá položka objektů z třídy Ucet
        //Se soukromou položkou pracuje jen objekt uvnitř ne mimo
        private double bilance;

        //veřejná vlastnost 
        public double Bilance
        {
            //vrací hodnotu soukromé položky
            get
            {
                //vrací hodnotu soukromé položky
                return bilance;
            }
            //nastavuje hodnotu soukromé položky
            set
            {
                double puvodniZustatek = bilance;
                //vepíše hodnotu veřejné vlastnosti do soukromé položky
                bilance = value;
                if(bilance < 0)
                {
                    bilance = puvodniZustatek;
                    Console.WriteLine("Nelze vybrat více než je na účtu");
                }
            }
        }





        /* Ověření hodnoty pro změnu vlastnosti přes metodu
        public void Vyber(double castka)
        {
            if(castka<Bilance)
            {
                Bilance -= castka;
            } else
            {
                Console.WriteLine("Nemůžeš vybrat víc peněz než je na účtu!");
            }
        }
        */
    }
}
