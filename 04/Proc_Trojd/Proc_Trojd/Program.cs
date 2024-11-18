namespace Proc_Trojd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int strana = 0;
            Console.WriteLine("Zadej délku strany trojuhelníku?");
            while (!int.TryParse(Console.ReadLine(), out strana))
            {
                Console.WriteLine("Zadej číslo");
            }

            for (int i = 0; i < strana; i++)
            {
                for (int j = 0; j < strana-1-i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i+1; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
