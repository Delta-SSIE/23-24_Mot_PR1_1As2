﻿namespace Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tohle je komentář!

            /*
             * Komentář
             * na
             * více
             * řádků
             */
            
            Console.WriteLine("Ahoj světe!"); //Komentář, lze napsat za příkaz!

            //Výstup pro uživatele
            //Výpis do řádku, který se pak zalomí
            Console.WriteLine("Tento text se napíše do řádku a pak se zalomí.");
            //Výpis do řádku, který se nezalomí
            Console.Write("Tohle je text 1.");
            Console.Write(" a ");
            Console.Write("tohle je text 2.");
            Console.WriteLine();

            //Deklarace proměné int
            int vek;
            //Vložení hodnoty do deklarované proměné.
            vek = 28;
            //Výpis proměné
            Console.WriteLine(vek);

            //Deklarace proměné string s hodnotou
            string jmeno = "Jan";
            //Výpis proměné
            Console.WriteLine(jmeno);

            //Deklarace proměnných na jednom řádku
            int x = 5, y = 6;

            //Přepis hodnot proměnných (do proměné vek vkládám obsah (hodnotu) proměné y)
            vek = y;

            //Výpis více proměných najednou
            Console.WriteLine("Moje jméno je " + jmeno + " a můj věk je " + vek + " let.");

            //Výpis více proměných pomocí $
            Console.WriteLine($"Moje jméno je {jmeno} a můj věk je {vek} let.");

            //Výpis více promených pomocí pořadových čísel
            Console.WriteLine("Moje jméno je {0} a můj věk je {1} let.",jmeno,vek);

            //Příklad využití výpisu více proměnných na jednom řádku
            string ulice = "Kamenická";
            int cisloPopisne = 15;
            Console.WriteLine($"Bydlím v ulici {ulice} a číslo popisné je {cisloPopisne}.");

            //Long
            // int a = 500000000000000000; nelze napsat (pro int max. 2 miliony)
            long b = 500000000000000000; //long pro velká čísla

            //Proměné pro desetiná čísla
            float c = 2.15555555555555F; //F za desetinným místem, pouze 7 des. míst
            double e = 5.555555555555555555;
            Console.WriteLine(c + " " + e);

            //Boolean - drží jenom true, nebo false (pravda/nepravda)
            bool f = true;
            bool g = false;
            Console.WriteLine(f + " " + g);

            //Char
            char h = 'a'; //použít pouze jedny uvozovky (')
            Console.WriteLine(h);






        }
    }
}