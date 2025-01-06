namespace Proc_JeVNorme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JeVNorme(35.1, 33, 3.5)); //true
            Console.WriteLine(JeVNorme(35.1, 33, 1.5)); //false
            Console.WriteLine(JeVNorme(11.8, 13, 1.3)); //true

            Console.WriteLine(JeVNorme(2.2, 2, 0.2));
            Console.WriteLine(JeVNorme(2.6, 2, 0.2));

        }

        static bool JeVNorme(double skut_roz, double spravny_roz, double tol)
        {
            if(skut_roz <= spravny_roz + tol && skut_roz >= spravny_roz - tol)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
