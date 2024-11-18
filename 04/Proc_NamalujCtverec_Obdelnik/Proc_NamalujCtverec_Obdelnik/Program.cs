namespace Proc_NamalujCtverec_Obdelnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Čtverec
            int delka = 0;
            Console.WriteLine("Zadej mi délku strany čtverce?");
            while (!int.TryParse(Console.ReadLine(), out delka))
            {
                Console.WriteLine("Zadej číslo!");
            }

            for (int i = 0; i < delka; i++)
            {
                for (int j = 0; j < delka; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }

            int delkaObA = 0;
            int delkaObB = 0;
            Console.WriteLine("Zadej mi délku stranu obdelníku A?");
            while (!int.TryParse(Console.ReadLine(), out delkaObA))
            {
                Console.WriteLine("Zadej číslo!");
            }
            Console.WriteLine("Zadej mi délku stranu obdelníku B?");
            while (!int.TryParse(Console.ReadLine(), out delkaObB))
            {
                Console.WriteLine("Zadej číslo!");
            }

            for (int i = 0; i < delkaObB; i++)
            {
                for (int j = 0; j < delkaObA; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
        }
    }
}
