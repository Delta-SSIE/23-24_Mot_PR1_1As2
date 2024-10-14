namespace Nahodna_Cisla
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random(); //deklarace generátoru, pouze jednou v celém kodu.

            //generování náhodných čísel (0 až max velikost int)
            Console.WriteLine(rand.Next());

            //Generování čísel na určité škále (v intervalu)
            Console.WriteLine(rand.Next(0,2)); //dolní mez 0 a horní mez 2 (generuje se bez horní mezi), takže se bude generovat 0 a 1

            //Simulace hodu mincí
            switch(rand.Next(0, 2))
            {
                case 0:
                    Console.WriteLine("Padla Panna");
                    break;
                case 1:
                    Console.WriteLine("Padl Orel");
                    break;
            }

            //Simulace hodu 6-stěnnou kostkou
            Console.WriteLine(rand.Next(1,7)); //1-6

            //Generovace desetinných čísel
            Console.WriteLine(rand.NextDouble()); //generouje číslo mezi 0 a 1

            //Generace náhodného znaku velké abecedy
            int cislo = rand.Next(65, 91); //65-90 (65 - A; 90 - Z)
            char pismeno = (char)cislo;
            Console.WriteLine(pismeno);


        }
    }
}
