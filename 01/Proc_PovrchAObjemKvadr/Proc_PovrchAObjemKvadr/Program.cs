namespace Proc_PovrchAObjemKvadr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sem přijde váš kód
            Console.WriteLine("Tento program slouží k výpočtu objemu a pvrchu kvádru.");
            Console.Write("Zadej mi stranu a (v cm): ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Zadej mi stranu b (v cm): ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Zadej mi stranu c (v cm): ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"Povrch kvádru se rovná {2 * (a * b + a * c + b * c)} a objem se rovná {a * b * c}");


            // Konec prostoru pro kód
        }
    }
}
