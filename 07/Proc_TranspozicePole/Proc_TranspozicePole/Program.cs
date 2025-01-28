namespace Proc_TranspozicePole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] tabulka1 =
            {
            {3, 4, 7},
            {5, 9, 1},
            {1, 3, 2}
        };

            Console.WriteLine();

            int[,] tabulka2 =
            {
            {3, 1, 0},
            {2, 4, 5},
            {6, 7, 1},
            {0, 1, 2}
        };

            Console.WriteLine();

            int[,] transpozice1 = Transponuj(tabulka1);
            Vypis2DPole(transpozice1);

            int[,] transpozice2 = Transponuj(tabulka2);
            Vypis2DPole(transpozice2);

            //tohle by mělo vypsat nezměněné pole tabulka1 - jsou tam 2 transpozice za sebou
            Vypis2DPole(Transponuj(Transponuj(tabulka1)));
        }

        static int[,] Transponuj(int[,] pole)
        {
            //Nové pole má počet řádků jako mělo původní pole počet sloupců a naopak
            int[,] trans_pole = new int[pole.GetLength(1), pole.GetLength(0)];

            //Průchod polem po sloupcích a ne po řádcích
            for (int i = 0; i < pole.GetLength(1); i++)
            {
                for (int j = 0; j < pole.GetLength(0); j++)
                {
                    trans_pole[i,j] = pole[j,i];
                }
            }
            return trans_pole;

        }

        public static void Vypis2DPole(int[,] pole)
        {
            //do kódu této metody nezasahujte
            for (int y = 0; y < pole.GetLength(0); y++)
            {
                for (int x = 0; x < pole.GetLength(1); x++)
                {
                    Console.Write(pole[y, x]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
