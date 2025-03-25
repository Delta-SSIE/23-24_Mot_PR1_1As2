using System.Runtime.ConstrainedExecution;

namespace Proc_SeznamCisel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();
            List<int> cisla = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                cisla.Add(gen.Next(0, 1000000));
            }

            foreach (int cislo in cisla)
            {
                Console.Write(cislo + ", ");
            }

            Console.WriteLine();

            Console.WriteLine("Zadej číslo");
            int number = int.Parse(Console.ReadLine());
            cisla.Add(number);

            Console.WriteLine(cisla.Sum() / cisla.Count());
            Console.WriteLine(cisla.Sum());

            /*
            foreach (int cislo in cisla)
            {
                if (cislo > 0 && cislo < 100001)
                {
                    cisla.Remove(cislo);
                }
            }
            foreach (int cislo in cisla)
            {
                Console.Write(cislo + ", ");
            }
            */

            


        }
    }
}
