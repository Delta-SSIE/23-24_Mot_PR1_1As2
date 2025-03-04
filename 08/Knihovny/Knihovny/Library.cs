using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knihovny
{
    internal class Library
    {
        public string Name;
        public string Location;
        public Book[] Books;
        public Author[] Authors;

        //Konstruktor
        public Library(string n, string l)
        {
            Name = n;
            Location = l;
            Books = new Book[0];
            Authors = new Author[0];
        }

        public void AddBook(Book kniha)
        {
            bool existence = false;
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i] == kniha)
                {
                    Console.WriteLine("Zadaná kniha, již v knihovně existuje");
                    existence = true;
                    break;
                }
            }
            if(!existence)
            {
                Array.Resize(ref Books, Books.Length + 1);
                Books[Books.Length - 1] = kniha;
            }

        }

        public string FindBookByAuthor(string jmeno)
        {
            string seznam = "";
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Author.Name == jmeno)
                {
                    seznam += Books[i].Name +", ";
                }
            }
            return seznam;
        }
    }
}
