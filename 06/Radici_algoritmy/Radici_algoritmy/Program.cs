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
            int[] s_pole = { 21, 3, 10, 8, 13, 6 };
            VypisPole(SelectionSort(s_pole));
            int[] b_pole = { 21, 3, 10, 8, 13, 6 };
            VypisPole(BubbleSort(b_pole));

        }

        static int[] BubbleSort(int[] pole)
        {

            return pole;
        }

        static int[] SelectionSort(int[] pole)
        {
            int iMin = 0;
            for (int i = 0; i < pole.Length; i++) //Vnější cyklus
            {
                iMin = i;
                for (int j = i; j < pole.Length; j++) //Vnitřní cyklus
                {
                    if (pole[iMin] > pole[j])
                    {
                        iMin = j;
                    }
                   
                }
                pole = Prohod(pole, iMin, i);
                
            }
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
