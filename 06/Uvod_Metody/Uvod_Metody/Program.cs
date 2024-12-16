namespace Uvod_Metody
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pozdrav(); //Zavolání metody Pozdrav

            for (int i = 0; i < 5; i++)
            {
                Pozdrav(); //Zavolání metody Pozdrav
            }

            Dvojnasob(5); //Zavolání metody Dvojnásob s argumentem 5 (ten naplní parametr cislo)
            for (int i = 0; i < 5; i++)
            {
                Dvojnasob(i); //Zavolání metody Dvojnásob s argumentem i
            }

            //Zavolání metody PozdravV2 s různými argumenty
            PozdravV2("John");
            PozdravV2("Henry");
            PozdravV2("Rudolph");

            //Zavolání metody s dvěma argumenty
            Nasob(5, 3); //cislo = 5 a nasobek = 3

            //PozdravV2 předdefinovaná hodnota parametru
            PozdravV2(); //pokud nezadám argument, tak to použije předepsanou hodnotu "Larry"!
            PozdravV2("George"); //Pokud zadám argument, tak se NEpoužije předepsaná hodnota!

            //Metoda s návratovou hodnotou pro ověření vstupu (int)
            int cislo1 = OverCislo(); //návratová hodnota (cislo) se načte do proměnné cislo1
            int cislo2 = OverCislo(); //návratová hodnota (cislo) se načte do proměnné cislo2
            Console.WriteLine(cislo1+cislo2);

            //Metody s návratovou hodnotou pro práci s polem
            int[] pole1 = new int[20];
            int[] pole2 = new int[50];

            pole1 = NactiPole(pole1); //pole načte do sebe hodnoty vrácené z metody
            pole2 = NactiPole(pole2);

            VypisPole(pole1); //pole se vypíše uvnitř zavolané metody
            VypisPole(pole2);

            //Method overloading
            Scitej(1, 5);
            Scitej(1.5, 1.6);
            Scitej(5, 5);
            Scitej(5.2, 10.2);

        }

        //Nová metoda Pozdrav()
        static void Pozdrav()
        {
            Console.WriteLine("Hello!");
        }

        //Metoda s parametrem int cislo
        static void Dvojnasob(int cislo) //parametr cislo
        {
            Console.WriteLine(cislo*2);
        }

        //Metoda s parametrem string jmeno
        //Parametr má předepsanou hodnotu "Larry"
        static void PozdravV2(string jmeno = "Larry")
        {
            Console.WriteLine("Hello " + jmeno);
        }

        //Metoda s dvěma parametry int cislo a int nasobek
        static void Nasob(int cislo, int nasobek)
        {
            Console.WriteLine(cislo*nasobek);
        }

        //Metoda s návratovou hodnotou (místo void se píše datový typ návratové proměnné v našem případě int)
        static int OverCislo()
        {
            int cislo = 0;
            while(!int.TryParse(Console.ReadLine(),out cislo))
            {
                Console.WriteLine("Zadej opravdu číslo!");
            }
            return cislo; //návratová hodnota (metoda vrací hodnotu v proměnné číslo zpět do Mainu)
        }

        //Metoda s návratovou hodnotou a parametrem
        static int[] NactiPole(int[] pole)
        {
            Random gen = new Random();
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = gen.Next(1, 11);
            }
            return pole;
        }

        //Metoda pro výpis pole
        static void VypisPole(int[] pole)
        {
            foreach (int cislo in pole)
            {
                Console.Write(cislo + ", ");
            }
            Console.WriteLine();
        }

        //method overloading
        static void Scitej(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        static void Scitej(double x, double y)
        {
            Console.WriteLine(x + y);
        }


    }
}
