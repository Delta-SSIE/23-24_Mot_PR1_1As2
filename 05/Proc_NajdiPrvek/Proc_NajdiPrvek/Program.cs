namespace Proc_NajdiPrvek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = new int[] { -11, 0, 5, -12, 13, 24, 19, 13, -17 };
            int cislo = 0;
            int index = -1;
            Console.WriteLine("Zadej mi číslo, které budeš v poli hledat!");
            while(!int.TryParse(Console.ReadLine(),out cislo))
            {
                Console.WriteLine("Zadej číslo!");
            }

            for (int i = 0; i < cisla.Length; i++)
            {
                if(cislo == cisla[i])
                {
                    index = i;
                    break; //vyskočení z cyklu
                }
            }
            if(index != -1)
            {
                Console.WriteLine($"{cislo} se nachází na indexu {index}.");
            } else
            {
                Console.WriteLine($"{cislo} se v poli nenachází.");
            }
            
        }
    }
}
