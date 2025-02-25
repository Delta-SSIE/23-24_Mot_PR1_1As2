namespace Exepctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zkus
            try
            {
                int cislo = int.Parse(Console.ReadLine());
            } catch //pokud kod není proveden bez chyby
            {
                Console.WriteLine("Měl si zadat číslo!");
            }

            try
            {
                int cislo2 = int.Parse(Console.ReadLine());
            }
            catch (Exception e) //pokud kod není proveden bez chyby
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
