namespace Operatory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;

            Console.WriteLine(x + y); //sčítání
            Console.WriteLine(y - x); //odčítání
            Console.WriteLine(x * y); //násobení
            Console.WriteLine(y / x); //dělení

            //Modulo %
            Console.WriteLine(10 % 2);
            Console.WriteLine(17 % 3);

            //Inkriminovat a deinkriminovat (zvyšování čísla, či snížování čísla o 1)
            x++; //x = x + 1
            x--; //x = x - 1

            //Přiřazovací operátory (zkracování kodu)
            x += 3; //x = x + 3;
            y -= 5; //y = y - 5;

            x *= 20; //x = x * 20;


            //Porovnávací operátory
            Console.WriteLine(x > y); //x je větší než y
            Console.WriteLine(y > x); //y je větší než x

            Console.WriteLine(x < y); //x je menší než y

            Console.WriteLine(x == y); // x rovná se y (==)

            Console.WriteLine(x <= y); //x je menší, či rovno y
            Console.WriteLine(x >= y); //x je větší, či rovno y
 

        }
    }
}
