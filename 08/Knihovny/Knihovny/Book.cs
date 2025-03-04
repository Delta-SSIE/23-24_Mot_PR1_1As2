using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knihovny
{
    internal class Book
    {
        public string Name;
        public int PubYear;
        public Author Author;

        public Book(Author[] poleAutoru)
        {
            Console.WriteLine("Zadej mi název knihy");
            string nazev = Console.ReadLine();
            Console.WriteLine("Zadej rok, kdy byla kniha pulikovaná");
            int rok = int.Parse(Console.ReadLine());

            //Nastavení hodnot vlastnosti, dle vstupu uživatele
            Name = nazev;
            PubYear = rok;


            //Zadaní jména autora
            Console.WriteLine("Zadej mi jméno autora:");
            string autorName = Console.ReadLine();
            bool kontrola = false; 

            for (int i = 0; i < poleAutoru.Length; i++)
            {
                if(autorName == poleAutoru[i].Name)
                {
                    Author = poleAutoru[i];
                    kontrola = true;
                    break;
                }
            }
            if(!kontrola)
            {
                Author = new Author(autorName);
            }
            
        }
    }
}
