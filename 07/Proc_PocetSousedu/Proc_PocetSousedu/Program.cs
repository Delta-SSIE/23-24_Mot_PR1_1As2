namespace Proc_PocetSousedu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool[,] mapa =
            {
                { true,  true,  false, false },
                { false, false, true,  true },
                { false, false, false, true },
                { false, false, true,  true },
            };

            Console.WriteLine(PocetSousedu(mapa, 0, 0)); //mělo by vypsat 1 - levý horní roh sousedí jen s jednou minou
            Console.WriteLine(PocetSousedu(mapa, 0, 3)); //mělo by vypsat 0 - levý dolní roh s žádnou minou nesousedí
            Console.WriteLine(PocetSousedu(mapa, 2, 2)); //mělo by vypsat 5

        }

        static int PocetSousedu(bool[,] mapa, int sourX, int sourY)
        {
            int pocetMin = 0;
            //sem přijde váš kód

            if(sourX != mapa.GetLength(1)-1)
            {
                if (mapa[sourX + 1, sourY] == true)
                {
                    pocetMin++;
                }
                if(sourY != 0)
                {
                    if (mapa[sourX + 1, sourY - 1] == true)
                    {
                        pocetMin++;
                    }
                }
                if(sourY != mapa.GetLength(0) - 1)
                {
                    if (mapa[sourX + 1, sourY + 1] == true)
                    {
                        pocetMin++;
                    }
                }
               
            }
            if(sourX != 0)
            {
                if (mapa[sourX - 1, sourY] == true)
                {
                    pocetMin++;
                }
                if (sourY != 0)
                {
                    if (mapa[sourX - 1, sourY - 1] == true)
                    {
                        pocetMin++;
                    }
                }
                if (sourY != mapa.GetLength(0) - 1)
                {
                    if (mapa[sourX - 1, sourY + 1] == true)
                    {
                        pocetMin++;
                    }
                }
            }

            if (sourY != 0)
            {
                if (mapa[sourX, sourY - 1] == true)
                {
                    pocetMin++;
                }
            }
            if (sourY != mapa.GetLength(0) - 1)
            {
                if (mapa[sourX, sourY + 1] == true)
                {
                    pocetMin++;
                }
            }
            return pocetMin;

        }
    }
}
