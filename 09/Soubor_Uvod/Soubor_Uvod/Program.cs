namespace Soubor_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Absolutní adresa - plocha
            //FileStream soubor = File.Create(@"C:\Users\mottja\Desktop\text.txt");
            //Relativní adresa - přímo v složce s programem
            //FileStream soubor = File.Create(@"slozka/text.txt");

            //Ověření existence souboru v rámci adresářové struktury programu
            if(File.Exists(@"slozka/text2.txt"))
            {
                Console.WriteLine("File exist!");
            } else
            {
                Console.WriteLine("File not exist!");
            }
            
            //Vepsaní textu do souboru (případně přepsaní toho, co v něm je)
            File.WriteAllText("text.txt", "Ahooooooj!");
            //Čtení dat ze souboru a výpis do konzole
            Console.WriteLine(File.ReadAllText("text.txt"));

            //StreamWriter a StreamReader
            StreamWriter sw = new StreamWriter("text.txt");
   
                sw.WriteLine("Hello");
                sw.WriteLine("Jak se máš?");
                sw.WriteLine("Co děláš?");
                sw.Close();
           

            StreamReader sr = new StreamReader("text.txt");
                string radek = sr.ReadLine();
                do
                {
                    Console.WriteLine(radek);
                    radek = sr.ReadLine();
                } while (radek != null);
                sr.Close();
    


        }
    }
}
