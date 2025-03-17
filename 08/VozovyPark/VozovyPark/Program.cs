using System;

namespace VozovyPark
{
    internal class Program
    {
        private static Random random = new Random();
        static void Main(string[] args)
        {

            Vozidlo[] NabidkaAut = new Vozidlo[100];

            for (int i = 0; i < NabidkaAut.Length; i++)
            {
                string spz = GenerateRandomSPZ();
                int rokVyroby = random.Next(1980, 2025); // Náhodný rok výroby mezi 1980 a 2024
                int km = random.Next(0, 100000); //Počet km

                NabidkaAut[i] = new Vozidlo(spz, rokVyroby, km);
            }

            Prodejce[] SeznamProdejcu = new Prodejce[10];

            for (int i = 0; i < SeznamProdejcu.Length; i++)
            {
                string[] jmena = { "Jan", "Petr", "Martin", "Josef", "Marek", "Tomáš", "Lukáš", "David", "Jakub", "Michal", "Ondřej", "Václav", "Filip", "Adam", "Daniel", "Karel", "Roman", "Radek", "Jaroslav", "Miroslav", "Zdeněk", "Jiří", "František", "Vojtěch", "Stanislav", "Milan", "Aleš", "Vladimír", "Ivan", "Robert", "Pavel", "Libor", "Jindřich", "Ladislav", "Rostislav", "Bohumil", "Vít", "Štěpán", "Erik", "Richard", "Rudolf", "Emil", "Antonín", "Miloš", "Oldřich", "Břetislav", "Vlastimil", "Leoš", "Zbyněk", "Bohuslav" };
                SeznamProdejcu[i] = new Prodejce(jmena[random.Next(0, jmena.Length)]);
            }

            while (true)
            {
                for (int i = 0; i < SeznamProdejcu.Length; i++)
                {
                    Console.WriteLine($"{i}. {SeznamProdejcu[i].Jmeno}");
                }
                Console.WriteLine("Vyber prodejce dle indexu");
                int index = int.Parse(Console.ReadLine());
                Console.Clear();

                while (true)
                {
                    for (int i = 0; i < NabidkaAut.Length; i++)
                    {
                        Console.Write($"{i} ");
                        NabidkaAut[i].VypisInfo();
                    }
                    int indexauta = int.Parse(Console.ReadLine());
                    Array.Resize(ref SeznamProdejcu[index].IndexyAut, SeznamProdejcu[index].IndexyAut.Length + 1);
                    SeznamProdejcu[index].IndexyAut[SeznamProdejcu[index].IndexyAut.Length - 1] = indexauta;

                    Console.WriteLine("---------------");
                    SeznamProdejcu[index].VypisAuta(NabidkaAut);

                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        private static string GenerateRandomSPZ()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] spz = new char[8];

            for (int i = 0; i < spz.Length; i++)
            {
                spz[i] = chars[random.Next(chars.Length)];
            }

            return new string(spz);
        }
    }
}
 
