﻿namespace Lode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int velikost_mapy = 0;
            Random gen = new Random();

            Console.WriteLine("Ahoj, vítej ve hře Lodí! \nJak velkou hrací plochu chceš?");
            while(!int.TryParse(Console.ReadLine(),out velikost_mapy))
            {
                Console.WriteLine("Zadej celé číslo");
            }

            //Tvorba tří hlavních polí pro většinu hry
            int[,] hrac_pole = GenerovaniMapy(velikost_mapy);
            int[,] hrac_strely = GenerovaniMapy(velikost_mapy);
            int[,] protihrac_pole = GenerovaniMapy(velikost_mapy);

            //Vkládání 1-lodí do pole
            hrac_pole = VlozJednaLode(hrac_pole, 3, false);
            protihrac_pole = VlozJednaLode(protihrac_pole, 3, false);

            //Zahájení hry
            while(PocetLodi(hrac_pole) > 0 && PocetLodi(protihrac_pole) > 0)
            {
                Console.Clear();
                Console.WriteLine("Vaše hrací pole:");
                VypisMapy(hrac_pole);
                Console.WriteLine("Pole střel:");
                VypisMapy(hrac_strely);
                Console.WriteLine($"Počet vašich lodí: {PocetLodi(hrac_pole)} \nPočet lodí nepřítele: {PocetLodi(protihrac_pole)}");

                //Střelba
                int x = OverSouradnici(protihrac_pole.GetLength(1), 'x');
                int y = OverSouradnici(protihrac_pole.GetLength(0), 'y');
                if (protihrac_pole[y,x] == 3)
                {
                    Console.WriteLine("Zásah!");
                    protihrac_pole[y, x] = 2;
                    hrac_strely[y, x] = 2;
                } else
                {
                    Console.WriteLine("Minuls!");
                    protihrac_pole[y, x] = 1;
                    hrac_strely[y, x] = 1;
                }

                //Střelba AI
                do
                {
                    x = gen.Next(0, hrac_pole.GetLength(1));
                    y = gen.Next(0, hrac_pole.GetLength(0));
                } while (hrac_pole[y, x] == 2 || hrac_pole[y, x] == 1);
                if (hrac_pole[y, x] == 3)
                {
                    Console.WriteLine("Zásah!");
                    hrac_pole[y, x] = 2;
                }
                else
                {
                    Console.WriteLine("Minuls!");
                    hrac_pole[y, x] = 1;
                }
            }

        }

        static int PocetLodi(int[,] mapa)
        {
            int p = 0;
            foreach (int souradnice in mapa)
            {
                if(souradnice == 3)
                {
                    p++;
                }
            }
            return p;
        }

        static int[,] VlozJednaLode(int[,] mapa, int pocetL, bool hrac)
        {
            int x = 0;
            int y = 0;
            Random gen = new Random();

            for (int i = 0; i < pocetL; i++)
            {
                if(hrac)
                {
                    VypisMapy(mapa);
                    x = OverSouradnici(mapa.GetLength(1),'x');
                    y = OverSouradnici(mapa.GetLength(0),'y');
                    Console.Clear();
                } else
                {
                    //Ai generování
                    do
                    {
                        x = gen.Next(0, mapa.GetLength(1));
                        y = gen.Next(0, mapa.GetLength(0));
                    } while (mapa[y, x] == 3);
                }
                mapa[y, x] = 3;
            }
            return mapa;
        }

        static int OverSouradnici(int strana, char osa)
        {
            int souradnice = 0;
            Console.WriteLine($"Zadej mi souřadnici pro osu {osa}:");
            while (!int.TryParse(Console.ReadLine(), out souradnice))
            {
                Console.WriteLine("Zadej celé číslo");
            }
            if(souradnice >= 0 && souradnice < strana)
            {
                return souradnice;
            } else
            {
                Console.WriteLine("Zadal si souřadnici mimo rozměr");
                OverSouradnici(strana,osa);
            }
            return souradnice;
        } 

        static void VypisMapy(int[,] mapa)
        {
            for (int i = 0; i < mapa.GetLength(0); i++)
            {
                for (int j = 0; j < mapa.GetLength(1); j++)
                {
                    switch(mapa[i,j])
                    {
                        case 0: //voda
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write('V');
                            break;
                        case 1: //střela minula
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write('S');
                            break; 
                        case 2: //zásah lodi
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write('Z');
                            break;
                        case 3: //loď
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write('L');
                            break;
                    }
                    Console.BackgroundColor = ConsoleColor.Black; //vracení barvy pozadí na černou
                }
                Console.WriteLine();
            }
        }

        //Metoda vygeneruje pole o zadané velikosti a naplní ho hodnotami pro vodu, tzn. prázdná hrací plocha
        static int[,] GenerovaniMapy(int velikost)
        {
            int[,] mapa = new int[velikost, velikost];
            for (int i = 0; i < mapa.GetLength(0); i++)
            {
                for (int j = 0; j < mapa.GetLength(1); j++)
                {
                    mapa[i, j] = 0; //nula je totiž voda
                }
            }

            return mapa;

        }
    }
}
