namespace Proc_PodLimitem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] cisla = { -1.3, 2.2, 1.5, 1.4, 2.7 };
            double[] cisla2 = { -1.6, 2.5, 3.5, 1.8, 2.2 };
            Console.WriteLine(PodLimitem(cisla, 1.5)); //vypíše -1.3 a 1.4 
            Console.WriteLine(PodLimitem(cisla, 1.6)); //vypíše -1.3 , 1.5 a 1.4
            Console.WriteLine(PodLimitem(cisla2, 2));
        }

        static string PodLimitem(double[] pole, double limit)
        {
            string cisla = " ";
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] < limit)
                {
                    cisla += pole[i] + ", ";
                }
            }
            return cisla;
        }
    }
}
