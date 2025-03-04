using System.Runtime;

namespace Knihovny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej mi název pro knihovnu");
            string kNazev = Console.ReadLine();
            Console.WriteLine("Zadej mi lokaci pro knihovnu");
            string kLokace = Console.ReadLine();

            //Tvorba nové instance z Třídy Library
            Library knihovna = new Library(kNazev, kLokace);
            Library kon_knihovna = new Library("Špatná knihovna", "Hradec Králové");

            while(true)
            {
                Console.Clear();
                Console.WriteLine($"Vítej ve správě knihovny {knihovna.Name}");
                Console.WriteLine($"Knihovna se nachází v {knihovna.Location}");
                Console.WriteLine("Pro vložení knihy dej 1. pro výpis knih 2.");
                int moznost = int.Parse(Console.ReadLine());

                switch(moznost)
                {
                    case 1:
                        Book novaKniha = new Book(knihovna.Authors);
                        knihovna.AddBook(novaKniha);
                        break;
                    case 2:
                        Console.WriteLine("Zadej mi jméno autora, dle kterého mám tituly hledat!");
                        string autor = Console.ReadLine();
                        Console.WriteLine(knihovna.FindBookByAuthor(autor));
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
