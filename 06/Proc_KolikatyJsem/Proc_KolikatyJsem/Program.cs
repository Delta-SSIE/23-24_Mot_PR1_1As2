namespace Proc_KolikatyJsem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 10, 15, 3, 7, 6, 20, 5, 8 };
            Console.WriteLine(Kolikaty(test, 0));
            Console.WriteLine(Kolikaty(test, 3));

        }

        /*
        static int Kolikaty(int[] vysledky, int index)
        {
            int student_vysledek = vysledky[index];
            Array.Sort(vysledky);
            Array.Reverse(vysledky);
  
            int poradi = 0;
            for (int i = 0; i < vysledky.Length; i++)
            {
                if(student_vysledek == vysledky[i])
                {
                    poradi = i + 1;
                }
            }

            return poradi;
        }
        */

        static int Kolikaty(int[] vysledky, int index)
        {
            int student_vysledek = vysledky[index];
            int poradi = 1;

            for (int i = 0; i < vysledky.Length; i++)
            {
                if(student_vysledek < vysledky[i] && i != index)
                {
                    poradi++;
                }
            }

            return poradi;
        }
    }
}
