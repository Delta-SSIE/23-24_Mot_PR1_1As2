namespace Proc_BalicekKaret
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] barva = { "Listy", "Žaludy", "Kule", "Srdce" };
            string[] vyska = { "sedma", "osma", "devět", "deset", "spodek", "svršek", "král", "eso" };
            string[] balicek = new string[32];

            for (int i = 0; i < barva.Length; i++)
            {
                for (int j = 0; j < vyska.Length; j++)
                {
                    balicek[j + (i*8)] = barva[i] + " - " + vyska[j];
                }
            }
            //Výpis balíčku
            foreach(string karta in balicek)
            {
                Console.WriteLine(karta);
            }
            Console.WriteLine();

            //Generování náhodné karty
            Random gen = new Random();
            Console.WriteLine(balicek[gen.Next(0,32)]);
            Console.WriteLine();

            //Vybrání deseti karet, co se neopakují
            int[] indexy_karet = new int[10];
            for (int i = 0; i < indexy_karet.Length; i++)
            {
                bool kontrola = false;
                int try_index = 0;
                while (!kontrola)
                {
                    try_index = gen.Next(0, 32);
                    for (int k = 0; k < indexy_karet.Length; k++)
                    {
                        if (indexy_karet[k] == try_index)
                        {
                            kontrola = true;
                        }
                    }

                    if(kontrola == true)
                    {
                        kontrola = false;
                    } else
                    {
                        kontrola = true;
                        
                    }
                }
                indexy_karet[i] = try_index;

            }
            //Výpis karet z balíčku na základě pole, kam se uložily náhodně vygenerované indexy
            foreach(int index in indexy_karet)
            {
                Console.WriteLine(balicek[index]);
            }

        }
    }
}
