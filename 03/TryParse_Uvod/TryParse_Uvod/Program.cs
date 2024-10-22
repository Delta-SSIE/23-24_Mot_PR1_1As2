namespace TryParse_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vstup = Console.ReadLine();
            int cislo = 0;

            Console.WriteLine(int.TryParse(vstup, out cislo)); //vstup je proměná, co bude parsována a cislo je proměná do které se má výstup z parsování nahrát

            //nahraje do proměnné cislo2, to co se zadá do konzole. Pokud neopodpovídá datový typ nahraje se 0.
            int.TryParse(Console.ReadLine(), out int cislo2);
            Console.WriteLine(cislo2);

            //Bezpečné načtení int
            int cislo3 = 0;
            while (!int.TryParse(Console.ReadLine(), out cislo3))
                //Podmínka je negace TryParse. Kde se nahraje string z konzole (cr) a následně se výstup int vloží do proměnné cislo3
            {
                Console.WriteLine("Zadej čislo!");
            }
            Console.WriteLine(cislo3);

            //Verze s DoWhile
            int cislo4 = 0;
            do
            {
                Console.WriteLine("Zadej čislo!");
            } while (!int.TryParse(Console.ReadLine(), out cislo4));
            Console.WriteLine(cislo4);
        }   
    }
}
