using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knihovny
{
    internal class Author
    {
        public string Name;
        public int BirthYear;

        //Konstruktor pro třídu Autor
        public Author(string j)
        {
            Name = j;
            Console.WriteLine("Zadej mi rok narození");
            BirthYear = int.Parse(Console.ReadLine());
        }
    }
}
