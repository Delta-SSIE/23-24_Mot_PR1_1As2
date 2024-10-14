namespace IQ_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int skore = 0;

            Console.WriteLine("Kolik je 2+4?");
            int odpoved1 = int.Parse(Console.ReadLine());
            if (odpoved1 == 6)
            {
                skore += 5; //skore = skore + 5
            } else
            {
                skore -= 3; //skore = skore - 3
            }

            Console.WriteLine("Napiš první znak abecedy");
            char odpoved2 = Console.ReadKey().KeyChar; //Načtení pouze znaku
            if (odpoved2 == 'A' || odpoved2 == 'a') //Pokud opoeved2 se rovna 'A' nebo se rovna 'a', tak...
            {
                skore += 5; //skore = skore + 5
            }
            else
            {
                skore -= 3; //skore = skore - 3
            }
            Console.WriteLine("Je číslo 13 sudé? (A/N)");
            char odpoved3 = Console.ReadKey().KeyChar; //Načtení pouze znaku
            if (odpoved3 == 'A')
            { 
                skore += 5; //skore = skore + 5
            }
            else
            {
                skore -= 3; //skore = skore - 3
            }

            Console.WriteLine($"Celkově si získal {skore}");
        }
    }
}
