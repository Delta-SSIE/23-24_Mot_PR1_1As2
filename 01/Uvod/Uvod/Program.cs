namespace Uvod
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

            //Implicit casting char --> int
            int cisloChar = h;
            Console.WriteLine(cisloChar);

            //Explicit casting int --> char
            char i = (char) 99;
            Console.WriteLine(i);

            //Parsováním (při parsování vždy dodržujeme syntaxi datovyTyp.Parse(proměnnáOrigo)
            string textA = "97";
            int cisloA = int.Parse(textA);
            Console.WriteLine(cisloA+3);

            //Convertování (při convertování vždy dodržujeme syntaxi Convert.ToDatovyTyp(proměnnáOrigo)
            int cisloB = 98;
            string textB = Convert.ToString(cisloB);
            Console.WriteLine(textB+2);

            int cisloC = Convert.ToInt32(textB);
            Console.WriteLine(cisloC+2);

            //Console.Readline

            Console.WriteLine("Napiš mi své jméno");
            string uzivJmeno = Console.ReadLine(); //načtení uživatelova vstupu do proměnné
            Console.WriteLine($"Uživatel se jmenuje: {uzivJmeno}");

            //Načtení int z vstupu uživatele pomocí Parse a Convert
            Console.Write("Napiš mi svůj věk:");
            int uzivVek = int.Parse(Console.ReadLine());
            Console.WriteLine($"Uživatel je starý: {uzivVek}");

            Console.Write("Napiš mi svůj věk:");
            int uzivVek2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Uživatel je starý: {uzivVek2}");

            //Sčítačka
            int o = 0;
            int u = 0;

            Console.WriteLine("Napiš číslo \"u\"");
            u = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Napiš číslo \"o\"");
            o = int.Parse(Console.ReadLine());

            Console.WriteLine($"Výsledek sčítání čísel u: {u} a o: {o} je {u+o}");









        }
    }
}
