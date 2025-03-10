using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesII
{
    internal class Pes
    {

        //definice soukromých položek 
        private string jmeno;
        private int nohy;
        private bool jeOckovany;


        //vlastnosti:
        //základní get a set
        public bool JeOckovany
        {
            get { return jeOckovany; }
            set { jeOckovany = value; }
        }

        //vlastnost Nohy
        public int Nohy
        {
            get
            {
                return nohy;
            }

            //nastavuje hodnotu soukromé položky dle podmínek
            set
            {
                if(value > 4 || value < 0)
                {
                    Console.WriteLine("Zadán nespravný počet končetin");
                } else
                {
                    nohy = value;
                }
              
            }
        }

        //vlastnost Jmeno
        public string Jmeno
        {
            get
            {
                return jmeno;
            }
            // mění dle podmínky zápis do soukromé položky
            set
            {
                if(value.Contains(" "))
                {
                    for (int i = 0; i < value.Length ; i++)
                    {
                        if (value[i] == ' ')
                        {
                            break;
                        } 
                        jmeno += value[i];
                    }
                } else
                {
                    jmeno = value;
                }
            }
        }



        //Metoda
        public string PredstavSe()
        {
            //metoda využívá vlastnosti objektů z třídy
            string ocko = (this.JeOckovany) ? "jsem očkovaný" : "nejsem očkovaný";
            return $"Já jsem pes, jmenuju se {this.Jmeno}, mám {this.Nohy} nohy a {ocko}.";
        }
    }
}
