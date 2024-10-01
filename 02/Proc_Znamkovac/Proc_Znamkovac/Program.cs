namespace Proc_Znamkovac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej mi procenta z testu ");
            float procenta = float.Parse(Console.ReadLine());

            switch (procenta)
            {
                case float a when (a <= 100 && a >= 83):
                    Console.WriteLine("Získal jsi známku 1!");
                    break;
                case float b when (b < 83 && b >= 67):
                    Console.WriteLine("Získal jsi známku 2!");
                    break;
                case float c when (c < 67 && c >= 50):
                    Console.WriteLine("Získal jsi známku 3!");
                    break;
                case float d when (d < 50 && d >= 33):
                    Console.WriteLine("Získal jsi známku 4!");
                    break;
                case float d when (d < 33 && d >= 0):
                    Console.WriteLine("Získal jsi známku 5!");
                    break;
                default:
                    Console.WriteLine("Špatně zadaná procenta!");
                    break;
            }
        }
    }
}
