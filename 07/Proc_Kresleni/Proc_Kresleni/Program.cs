namespace Proc_Kresleni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[,] mapa =
            {
                {  true, false, false,  true, false, false,  true},
                { false,  true, false,  true, false,  true, false},
                { false, false,  true,  true,  true, false, false},
                { false, false, false,  true, false, false, false},
            };

            VykresliPole(mapa);
            VykresliPole2(mapa, 'X', '-');
            VykresliPole2(mapa);
            VykresliPole2(mapa,'0');
        }

        static void VykresliPole(bool[,] pole)
        {
            for (int i = 0; i < pole.GetLength(0); i++) //Vnější cyklus pro průchod řádky
            {
                for (int j = 0; j < pole.GetLength(1); j++) //Vnitřní cyklus pro průchod sloupci
                {
                    /*
                    if (pole[i,j]) //pokud platí (pokud na indexu je hodnota "true")
                    {
                        Console.Write('#');
                    } else
                    {
                        Console.Write(' ');
                    }
                    */

                    //Shorthand if (terární opetátor)
                    Console.Write((pole[i,j] ? '#':' '));
                    //Zápis zkracené podmínky

                }
                Console.WriteLine();
            }
        }

        static void VykresliPole2(bool[,] pole, char znakT = '#', char znakF = ' ')
            //znakT a znakF mají předefinované hodnoty
        { 
            for (int i = 0; i < pole.GetLength(0); i++) //Vnější cyklus pro průchod řádky
            {
                for (int j = 0; j < pole.GetLength(1); j++) //Vnitřní cyklus pro průchod sloupci
                {
                    Console.Write((pole[i, j] ? znakT : znakF));

                }
                Console.WriteLine();
            }
        }
    }
}
