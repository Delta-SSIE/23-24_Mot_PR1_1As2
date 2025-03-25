using System.Globalization;
using System.Collections.Generic;

namespace Dictionary_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklarace slovníku
            Dictionary<string,Int32> dluznici = new Dictionary<string,Int32>();

            //přidání hodnot do slovníku v syntaxy – Klíč, Hodnota
            dluznici.Add("Vlaďa", 1000);
            dluznici.Add("Jarka", 100);
            dluznici.Add("Libor", 50);

            //Výpis klíčů ze slovníku
            foreach(string klic in dluznici.Keys)
            {
                Console.WriteLine(klic);
            }

            //Výpis hodnot ze slovníku
            foreach(int hodnota in dluznici.Values)
            {
                Console.WriteLine(hodnota);
            }

            //Výpis páru klíč-hodnota
            foreach (KeyValuePair<string, Int32> zaznam in dluznici)
            {
                Console.WriteLine($"Dluží mi {zaznam.Key} a suma, co mi dluží je {zaznam.Value}");
            }


            //vypisování hodnot na klíči
            Console.WriteLine(dluznici["Jarka"]);
            dluznici["Jarka"] += 500;
            Console.WriteLine(dluznici["Jarka"]);

            //Smazání prvku na klíči
            dluznici.Remove("Libor");
            foreach (KeyValuePair<string, Int32> zaznam in dluznici)
            {
                Console.WriteLine($"Dluží mi {zaznam.Key} a suma, co mi dluží je {zaznam.Value}");
            }

            //existence klíče, či hodnoty
            Console.WriteLine(dluznici.ContainsKey("Jarka")); //vrací true klíč existuje
            Console.WriteLine(dluznici.ContainsValue(1000));
            Console.WriteLine(dluznici.ContainsValue(100000)); //vrací false klíč neexistuje
            Console.WriteLine(dluznici.ContainsKey("Dalibor"));

        }
    }
}
