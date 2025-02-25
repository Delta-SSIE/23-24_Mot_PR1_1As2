using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc_Pes
{
    internal class Pes
    {
        //definice vlastností 
        public string Jmeno;
        public int Nohy;
        public bool JeOckovany;


        //Metoda
        public string PredstavSe()
        {
            //metoda využívá vlastnosti objektů z třídy
            string ocko = (this.JeOckovany) ? "jsem očkovaný" : "nejsem očkovaný";
            return $"Já jsem pes, jmenuju se {this.Jmeno}, mám {this.Nohy} nohy a {ocko}.";
        }
    }
}
