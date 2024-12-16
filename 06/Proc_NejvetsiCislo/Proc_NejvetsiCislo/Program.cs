namespace Proc_NejvetsiCislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cislo1 = 5.3;
            double cislo2 = 4.6;
            double cislo3 = 6.3;
            double maximum = Maximum(cislo1, cislo2, cislo3);
            Console.WriteLine($"Největší ze zadaných čísel je {maximum}.");
        }

        static double Maximum(double a, double b, double c)
        {
            /* Přes funkci Max
            double max1 = Math.Max(a, b);
            max1 = Math.Max(max1, c);
            return max1;
            */

            if(a > b)
            {
                if( a > c)
                {
                    return a;
                } else
                {
                    return c;
                }
            } else
            {
                if(b > c)
                {
                    return b;
                } else
                {
                    return c;
                }
            }
        }
    }
}
