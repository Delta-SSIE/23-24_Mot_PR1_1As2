namespace Uvod_Pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla; //deklarace pole int
            string[] slova; //deklarace pole stringů

            int[] numera = { 12, 1, 0, -5, 10 };
            //Deklarace pole s 5 hodnotami na rozmezí indexů 0–4
            string[] jmena = { "Lukáš", "Petr", "Barbora" };
            //Deklrace pole s 3 hodnotami string v rozmezí indexů 0–2


            //Vypsaní položky z pole
            Console.WriteLine(numera[0]); //vypíše prvek na 0 indexu (12)
            Console.WriteLine(jmena[1]); //vypíše prvek na 1 indexu (Petr)
            Console.WriteLine(numera[numera.Length-1]); //vypíše prvek na indexu délky pole -1 (5-1=4) (10)

            //Přepis položek v poli
            numera[0] = 0; //přepíše hodnotu na 0. indexu na 0
            numera[1] += 5; //zvýši hodnotu na 1. indexu o 5
            jmena[2] = "Jarmila"; //přepíše hodnotu na 2. indexu na "Jarmila"

            //vytvoření pole s předepsaným počtem hodnot (hodnoty jsou prázdné)
            int[] cisla2 = new int[10]; //Pole int o velikosti 10 bez zadaných hodnot
            string[] adresy = new string[5]; //Pole stringů o velikosti 5 bez zadaných hodnot

            Console.WriteLine(cisla2.Length); //vrací délku pole
            Console.WriteLine(adresy.Length); //vrací délku pole

            //Metody pro práci s poli čísel
            Console.WriteLine(numera.Max());
            Console.WriteLine(numera.Min());
            Console.WriteLine(numera.Sum());

            //Průchod pole

            //Průchod polem pomocí for cyklu
            for (int i = 0; i < numera.Length; i++)
            {
                Console.Write(numera[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < jmena.Length; i++)
            {
                Console.Write(jmena[i] + " ");
            }
            Console.WriteLine();

            //Průchodem polem pomocí foreach
            foreach (int numero in numera)
            {
                Console.WriteLine(numero);
            }

            foreach (string jmeno in jmena)
            {
                Console.WriteLine(jmeno);
            }


        }
    }
}
