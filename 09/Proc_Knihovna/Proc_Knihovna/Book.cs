using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc_Knihovna
{
    internal class Book
    {

        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string t, string a)
        {
            Title = t;
            Author = a;
        }

        public string DisplayInfo()
        {
            return $"{Title} napsal {Author}";
        }
    }
}
