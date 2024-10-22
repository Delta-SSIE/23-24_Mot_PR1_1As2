using System.Runtime.Intrinsics.Arm;

namespace Proc_KdyzPadneSestka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();
            /* Level 1
            char odp = ' ';
            
            do
            {
                int pokusy = 1;
                while (gen.Next(1,7) != 6)
                {
                    pokusy++;
                }
                Console.WriteLine("Konečně jsi hodil šestku, bylo to na {0}.pokus", pokusy);
                Console.WriteLine("Chceš opakovat, pokud ne zmáčkni \"n\"");
                odp = Console.ReadKey().KeyChar;
            } while (odp != 'n');
            */

            //Level 2
            double pocetPokusu = 1;
            double pokusy = 0;
            int maxHodu = 1;
            int pocetKolo = 0;

            do
            {
                pocetKolo = 1;
                pokusy++;
                while (gen.Next(1, 7) != 6)
                {
                    pokusy++;
                    pocetKolo++;
                }
                if (maxHodu < pocetKolo)
                {
                    maxHodu = pocetKolo;
                }
                pocetPokusu++;
            } while (pocetPokusu <= 1000);

            Console.WriteLine($"Průměrný počet hodů na hození šestky je {pokusy/pocetPokusu} a nejvyšší počet hodů v kole k hození šestky byl {maxHodu}");
        }
    }
}
