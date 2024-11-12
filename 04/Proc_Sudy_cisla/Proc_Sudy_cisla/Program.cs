namespace Proc_Sudy_cisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sude = 0;
            int cislo = 0;

            for (int i = 1; i < 11; i++)
            {
                do
                {
                    Console.WriteLine($"Zadej číslo na {i}.pozici!");
                } while (!int.TryParse(Console.ReadLine(), out cislo));

                if(i % 2 == 0)
                {
                    sude += cislo;
                }
            }

            Console.WriteLine($"Součet čísel na sudých pozicích je {sude}");
        }
    }
}
