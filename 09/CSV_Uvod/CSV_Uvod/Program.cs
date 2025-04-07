namespace CSV_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] studenti = new string[1000, 4];

            //Načtení dat z csv
            StreamReader sr = new StreamReader("data.csv");
            string radek = sr.ReadLine();
            for (int i = 0; i < studenti.GetLength(0); i++)
            {
                string[] student = radek.Split(",");
                for (int j = 0; j < studenti.GetLength(1); j++)
                {
                    studenti[i, j] = student[j];
                }
                radek = sr.ReadLine();
            }
            sr.Close();

            //vypsaní dat do konzole
            for (int i = 0; i < studenti.GetLength(0); i++)
            {
                for (int j = 0; j < studenti.GetLength(1); j++)
                {
                    Console.Write(studenti[i,j] + " ");
                }
                Console.WriteLine();
            }

            //změna dat v 2D poli
            studenti[0, 0] = "10";
            studenti[0, 1] = "John";
            studenti[0, 2] = "Gordon";
            studenti[0, 3] = "johngor@gmail.com";

            //zapsaní 2D pole do souboru csv
            StreamWriter sw = new StreamWriter("data.csv");
            for (int i = 0; i < studenti.GetLength(0); i++)
            {
                radek = "";
                for (int j = 0; j < studenti.GetLength(1); j++)
                {
                    radek += studenti[i, j] + ",";
                }
                sw.WriteLine(radek);
            }
            sw.Close();






        }
    }
}
