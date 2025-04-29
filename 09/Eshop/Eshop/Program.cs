using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text.Json;

namespace Eshop
{

    internal class Program
    {
        //Dynamické struktury, které budou držet informace ze zdrojových souborů po zapnutí programu
        public List<Item> shop = new List<Item>();
        public List<User> users = new List<User>();

        public void Main(string[] args)
        {
            NacistDataI(shop, "data/drink.json");
            NacistDataI(shop, "data/food.json");
            NacistDataU(users, "data/admin.json");
            NacistDataU(users, "data/customer.json");
        }

        public void NacistDataU(List<User> list,string path)
        {
            string textsoubor = File.ReadAllText(path);
            User[] pole_uz = JsonSerializer.Deserialize<User[]>(textsoubor);
            users.AddRange(pole_uz);
        }

        public void NacistDataI(List<Item> list, string path)
        {
            string textsoubor = File.ReadAllText(path);
            Item[] pole_it = JsonSerializer.Deserialize<Item[]>(textsoubor);
            shop.AddRange(pole_it);
        }
    }
}
