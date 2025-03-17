using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VozovyPark
{
    internal class Vozidlo
    {
        //Soukromé položky
        private string spz;
        private int rokVyroby;
        private double najeteKM;

        //Veřejné vlastnosti
        public bool Dostupnost { get; set; }

        public string SPZ
        {
            get
            {
                return spz;
            }
            set
            {
                if(value.Length == 8)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if ((value[i] > 47 && value[i] < 59) || (value[i] > 64 && value[i] < 107))
                        {
                            spz += value[i];
                        }
                    }
                }
                if(spz.Length != 8)
                {
                    spz = "";
                }
            }
        }

        public int RokVyroby
        {
            get
            {
                return rokVyroby;
            }
            set
            {
                if(value > 1865 && value < 2025)
                {
                    rokVyroby = value;
                }
            }
        }

        public double NajeteKM
        {
            get
            {
                return najeteKM;
            }
            set
            {
                if(value >= 0)
                {
                    najeteKM = value;
                }
            }
        }

        //Konstruktor
        public Vozidlo(string s, int rok, double km)
        {
            SPZ = s;
            RokVyroby = rok;
            NajeteKM = km;
            Dostupnost = true;
        }

        //Metodu VypisInfo()
        public void VypisInfo()
        {
            Console.WriteLine($"{SPZ}, rok výroby: {RokVyroby} a najeté km: {NajeteKM}"); ;
        }

    }
}
