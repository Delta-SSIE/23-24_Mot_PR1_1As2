namespace Proc_MalaNasobilka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej mi číslo se kterým provedu malou násobilku ");
            int cislo = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int pocitadlo = 1; //bude se zvyšovat a vždy jim budu násobit číslo;

            while (pocitadlo <= 10)
            {
                Console.WriteLine($"{pocitadlo}x{cislo}={pocitadlo*cislo}");
                pocitadlo++;
            }
        }
    }
}
