namespace Opakovani_2DPole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] pole = new int[3, 3];
            int pocitadlo = 1;

            //zápis čísel po řádcích
            for (int i = 0; i < pole.GetLength(0); i++) //řádky
            {
                for (int j = 0; j < pole.GetLength(1); j++) //sloupce
                {
                    pole[i, j] = pocitadlo;
                    Console.Write(pole[i, j] + " ");
                    pocitadlo++;
                }
                Console.WriteLine();
            }

            //zápis čísel po sloupcích
            pocitadlo = 1;
            for (int i = 0; i < pole.GetLength(1); i++) //sloupcích
            {
                for (int j = 0; j < pole.GetLength(0); j++) //řádcích
                {
                    pole[j, i] = pocitadlo;
                    pocitadlo++;
                }
            
            }
            for (int i = 0; i < pole.GetLength(0); i++) //řádky
            {
                for (int j = 0; j < pole.GetLength(1); j++) //sloupce
                {
                    Console.Write(pole[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
