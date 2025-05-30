﻿using System.Text.Json;

namespace json_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student studentA = new Student
            {
                id = 5,
                first_name = "John",
                last_name = "Fisher",
                email = "fish@fish.fish"
            };

            string json = JsonSerializer.Serialize(studentA);
            Console.WriteLine(json);

            Student studentB = JsonSerializer.Deserialize<Student>(json);
            Console.WriteLine(studentB.first_name + " " + studentB.last_name);


            //tahaní z zdrojového souboru
    
            Student[] studenti = JsonSerializer.Deserialize<Student[]>(File.ReadAllText("data.json"));

            for (int i = 0; i < studenti.Length; i++)
            {
                Console.WriteLine(studenti[i].first_name);
            }

            /*
            List<Student> lstudenti = new List<Student>(studenti);

            studenti = lstudenti.ToArray();
            */

            studenti[0].first_name = "Vavrich";
            studenti[0].last_name = "Benda";


            string string_studenti = JsonSerializer.Serialize(studenti);
            Console.WriteLine(string_studenti);

            File.WriteAllText("data.json", string_studenti);






        }
    }
}
