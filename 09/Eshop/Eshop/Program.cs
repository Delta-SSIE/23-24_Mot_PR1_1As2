using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text.Json;

namespace Eshop
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Dynamické struktury, které budou držet informace ze zdrojových souborů po zapnutí programu
            List<Item> shop = new List<Item>();
            List<User> users = new List<User>();

            NacistDataI(shop, "data/drink.json", "drink");
            NacistDataI(shop, "data/food.json", "food");
            NacistDataU(users, "data/admin.json", "admin");
            NacistDataU(users, "data/costumer.json", "user");

            User prihlaseny_uz = LogIn(users);

            while(true)
            {
                Console.WriteLine($"Vítej v eshopu!");
                prihlaseny_uz.DisplayInfo();
                foreach(Item zbozi in shop)
                {
                    zbozi.DisplayInfo();
                }
                Console.ReadLine();
            }
        }



        static User LogIn(List<User> users)
        {
            Console.WriteLine("Zadej své přihlašovací jméno");
            bool pod_jmeno = true;
            User nalezeny = null;
            do
            {
                string jmeno = Console.ReadLine();
                foreach (User uz in users)
                {
                    if (uz.username == jmeno)
                    {
                        pod_jmeno = false;
                        nalezeny = uz;
                        break;
                    }
                }
            } while (pod_jmeno);
            bool pod_heslo = true;
            Console.WriteLine($"Vítej uživateli {nalezeny.username} zadej své heslo: (Pokud se chceš přihlásit jako někdo jiný zadej 'e')");
            do
            {
                string heslo = Console.ReadLine();
                if(heslo == nalezeny.pass)
                {
                    pod_heslo = false;
                    break;
                }
                if (heslo == "e")
                {
                    return LogIn(users);
                }
            } while (pod_heslo);

            return nalezeny;

        }
        static void NacistDataU(List<User> list,string path, string type)
        {
            string textsoubor = File.ReadAllText(path);
            if(type == "admin")
            {
                Admin[] pole_uz = JsonSerializer.Deserialize<Admin[]>(textsoubor);
                list.AddRange(pole_uz);
            } else
            {
                Customer[] pole_uz = JsonSerializer.Deserialize<Customer[]>(textsoubor);
                list.AddRange(pole_uz);
            }
            
        }

        static void NacistDataI(List<Item> list, string path, string type)
        {
            string textsoubor = File.ReadAllText(path);
            if(type == "drink")
            {
                Drink[] pole_it = JsonSerializer.Deserialize<Drink[]>(textsoubor);
                list.AddRange(pole_it);
            } else
            {
                Food[] pole_it = JsonSerializer.Deserialize<Food[]>(textsoubor);
                list.AddRange(pole_it);
            }
            
            
        }
    }
}
