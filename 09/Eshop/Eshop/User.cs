using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop
{
    abstract class User : IDisplay
    {
        public string username { get; set; }
        public string pass { get; set; }
        public string email { get; set; }
        public string type { get; set; } 

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"User {username}, email: {email}");
        }
    }
}
