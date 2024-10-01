namespace Aritmetické_metody
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;

            //Hledání vyššího a nižšího čísla pomocí metody;
            Console.WriteLine(Math.Min(x, y));
            Console.WriteLine(Math.Max(x, y));

            //Odmocnina (druhá odmocnina)
            Console.WriteLine(Math.Sqrt(25));

            //Mocnina – první číslo je mocněné druhým
            Console.WriteLine(Math.Pow(5,2)); //5 na 2

            //Absolutní hodnota
            Console.WriteLine(Math.Abs(-20));

            //Zaokrouhlení
            Console.WriteLine(Math.Round(2.4));

            //PI
            Console.WriteLine(Math.PI);
        }
    }
}
