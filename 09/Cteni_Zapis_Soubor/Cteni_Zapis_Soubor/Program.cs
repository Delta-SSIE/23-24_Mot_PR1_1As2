using System.Linq.Expressions;

namespace Cteni_Zapis_Soubor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiš mi název souboru se kterým chceš pracovat");
            string name = Console.ReadLine();
            string path = name + ".txt";

            if(!File.Exists(path))
            {
                File.Create(path);
            }

            StreamReader sr = null;
            string radek = "";
            while (true)
            {
                Console.WriteLine("1/Read\n2/Write");
                int volba = int.Parse(Console.ReadLine());
                switch(volba)
                {
                    case 1:
                        sr = new StreamReader(path);
                        radek = sr.ReadLine();
                        while (radek != null)
                        {
                            Console.WriteLine(radek);
                            radek = sr.ReadLine();
                        }
                        sr.Close();
                        break;
                    case 2:
                        //Načtení hodnot do proměnné
                        string text = "";
                        //string[] pole_radku = new string[500];

                        sr = new StreamReader(path);
                        radek = sr.ReadLine();
                        //int pocitadlo = 0;
                        while (radek != null)
                        {
                            text += radek + "\n";
                            //pole_radku[pocitadlo] = radek;
                            //pocitadlo++;
                            radek = sr.ReadLine();
                        }
                        sr.Close();
                        Console.WriteLine("Piš, co chceš přidat do souboru. Skončíš prázdnou hodnotou.");
                        string psani = "";
                        do
                        {
                            psani = Console.ReadLine();
                            text += psani + "\n";
                            //pole_radku[pocitadlo] = psani;
                            //pocitadlo++;
                        } while (psani != "");

                        StreamWriter sw = new StreamWriter(path);
                        /* pole
                        for (int i = 0; i < pole_radku.Length; i++)
                        {
                            sw.WriteLine(pole_radku[i]);
                        }
                        */
                        sw.WriteLine(text); //text
                        sw.Close();
                        break;
                }
            }
        }
    }
}
