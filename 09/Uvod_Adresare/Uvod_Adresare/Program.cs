namespace Uvod_Adresare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("super_složka");

            if(Directory.Exists("super_složka"))
            {
                Directory.Delete("super_složka");
            }

            Directory.CreateDirectory("super_složka");

            //Directory.Move("super_složka", "Tada/super_složka");

            string path = "./";
            while(true)
            {
                var dirs = Directory.EnumerateDirectories(path);
                foreach (var dir in dirs)
                {
                    Console.WriteLine(dir);
                }
                Console.WriteLine("Napiš název adresáře. Pokud chceš o jedna dozadu, tak dej /");
                string volba = Console.ReadLine();

                if(volba == "/")
                {
                    path = "../" + path;

                } else
                {
                    if(Directory.Exists(volba))
                    {
                        path = path + volba + "/";
                    }
                }

            }
    


        }
    }
}
