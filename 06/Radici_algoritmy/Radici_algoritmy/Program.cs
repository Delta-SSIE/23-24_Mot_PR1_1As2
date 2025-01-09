using System.Diagnostics;

namespace Radici_algoritmy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] m_pole = { 21, 3, 10, 8, 13, 6 };
            VypisPole(m_pole);
            VypisPole(NajdiMin(m_pole));
            VypisPole(NajdiMax(m_pole));
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            int[] s_pole = NaplnNahodne(1000);
            int[] s = SelectionSort(s_pole);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
            stopwatch.Reset();
            stopwatch.Start();
            int[] b_pole = NaplnNahodne(1000);
            int[] b = BubbleSort(s_pole);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
            stopwatch.Reset();
            stopwatch.Start();
            int[] met_pole = NaplnNahodne(100000000);
            Array.Sort(met_pole);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);


        }

        static int[] NaplnNahodne(int pocet)
        {
            int[] pole = new int[pocet];
            Random gen = new Random();
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = gen.Next(0, 100001);
            }
            return pole;
        }
 
        static int[] BubbleSort(int[] pole)
        {
            int kroky = 0;
            for (int i = 1; i < pole.Length; i++)
            {
                kroky++;
                for (int j = 0; j < pole.Length-i; j++)
                {
                    kroky++;
                    if (pole[j] > pole[j + 1])
                    {
                        pole = Prohod(pole, j, j + 1);
                    }
                }
            }
            Console.WriteLine(kroky);
            return pole;
        }

        static int[] SelectionSort(int[] pole)
        {
            int kroky = 0;
            int iMin = 0;
            for (int i = 0; i < pole.Length; i++) //Vnější cyklus
            {
                kroky++;
                iMin = i;
                for (int j = i; j < pole.Length; j++) //Vnitřní cyklus
                {
                    kroky++;
                    if (pole[iMin] > pole[j])
                    {
                        iMin = j;
                    }
                   
                }
                pole = Prohod(pole, iMin, i);
                
            }
            Console.WriteLine(kroky);
            return pole;
        }
        static int[] NajdiMax(int[] array)
        {
            int iMax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[iMax] < array[i])
                {
                    iMax = i;
                }
            }
            array = Prohod(array, array.Length - 1, iMax);
            return array;

        }

        static int[] NajdiMin(int[] array)
        {
            int iMin = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[iMin] > array[i])
                {
                    iMin = i;
                }
            }
            array = Prohod(array, iMin, 0);
            return array;
        }

        static int[] Prohod(int[] array, int i1, int i2)
        {
            int p = array[i1];
            array[i1] = array[i2];
            array[i2] = p;
            return array;
        }

        static void VypisPole(int[] pole)
        {
            foreach (int cislo in pole)
            {
                Console.Write(cislo + " ");
            }
            Console.WriteLine();
        }
    }
}
