namespace Proc_PoSchodoch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int patra = 0;
            Console.WriteLine("Zadej mi počet pater?");
            while(!int.TryParse(Console.ReadLine(),out patra))
            {
                Console.WriteLine("Zadej číslo!");
            }

            for (int i = 0; i < patra; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
        }
    }
}
