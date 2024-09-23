namespace Proc_PrevodCasu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //deklarace pomocných proměnných
            float m = 0;
            float h = 0;
            
            Console.Write("Zadej mi čas v sekundách ");
            float s = float.Parse(Console.ReadLine());

            h = (s - s % 3600) / 3600;
            s = s % 3600;
            m = (s - s % 60) / 60;
            s = s % 60;

            Console.WriteLine($" Sekundy: {s}; Minuty: {m}; Hodiny: {h}.");
        }
    }
}
