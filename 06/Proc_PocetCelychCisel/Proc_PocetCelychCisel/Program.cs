namespace Proc_PocetCelychCisel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] cisla = { 1.3, 1.7, 2, 3.1, 0.1, -1 };
            //obsahuje 2 celá čísla, 2 a -1

            Console.WriteLine(
                "Pole  [{0}] obsahuje {1} celých čísel",
                string.Join("; ", cisla),
                PocetCelych(cisla)
            );

            double[] cisla2 = { 1, 1, 2, 3.1, 0.1, -1 };

            Console.WriteLine(
                "Pole  [{0}] obsahuje {1} celých čísel",
                string.Join("; ", cisla2),
                PocetCelych(cisla2)
            );
        }

        //Metoda má navratovou hodnotu int
        //Metoda má jeden parametr, což je pole doublů
        static int PocetCelych(double[] pole)
        {
            int pocet_celych = 0;
            foreach (double cislo in pole) //průchod pole
            {
                if(cislo % 1 == 0) //zjištění, zdali je číslo celé
                {
                    pocet_celych++; //přičtení k počítadlu
                }
            }
            return pocet_celych; //návratová hodnota
        }
    }
}
