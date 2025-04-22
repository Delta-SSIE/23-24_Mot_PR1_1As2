using System.Text.Json;

namespace JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "data.json";
            User[] pole_uz;
            try
            {
                pole_uz = JsonSerializer.Deserialize<User[]>(File.ReadAllText(path));
            } catch
            {
                pole_uz = [];
            }
            List<User> list_uz = new List<User>(pole_uz);
            
            //tohle je body programu, kde se manipuluje jen s listem

            for (int i = 0; i < list_uz.Count; i++)
            {
                Console.WriteLine(list_uz[i].Identify()); 
            }

            list_uz.Add(new User { id = 10, first_name = "Jan", last_name = "Brook", email = "j@j.com", ip_address = "1" });

            list_uz[0].first_name = "Bohuna";

            list_uz.Remove(list_uz[5]);

            //tady list uložím opět do jsonu


            pole_uz = list_uz.ToArray();
            string text = JsonSerializer.Serialize<User[]>(pole_uz);
            File.WriteAllText(path, text);

            //vytvoření reportu do txt
            //File.Create("report.txt");
            
            StreamWriter sr = new StreamWriter("report.txt");
            for (int i = 0; i < list_uz.Count; i++)
            {
                sr.WriteLine(list_uz[i].Identify());
            }
            sr.Close();




        }
    }
}
