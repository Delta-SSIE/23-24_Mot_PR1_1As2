namespace Proc_PruzkumTolerance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sousedi = { "Mekuřan", "Venušan", "Pozemšťan", "Marťan", "Jupiteřan", "Saturňan", "Uraňan", "Neptuňan" };
            string[] respondenti = { "Alois", "Bedřich", "Cyril", "Dušan", "Emil", "Filip", "Gustav" };

            bool[,] vysledky =
            {
            {  true, false, false, false,  true,  true, true,  true },
            {  true,  true,  true,  true,  true, false, true,  true },
            {  true,  true, false,  true,  true,  true, true, false },
            { false,  true,  true,  true,  true, false, true,  true },
            {  true, false, false,  true, false, false, true, false },
            {  true, false, false,  true,  true, false, true, false },
            {  true, false, false,  true, false, false, true,  true },
            };

            Console.WriteLine($"Nejpopulárnější soused je {sousedi[NejPop(vysledky,true)]}" +
                $"\nNejméně populární soused je {sousedi[NejPop(vysledky,false)]}");

        }

        static int NejPop(bool[,] tol, bool pop)
        {
            int indexPop = 0; //Index nejpopulárnějšího
            int pocitadlo_aktu = 0; //Počítadlo true
            int pocitadlo_max = 0; //Proměnná na držení nejvyššího součtu true

            for (int i = 0; i < tol.GetLength(1); i++) //vnější cyklus po sloupcích
            {
                for (int j = 0; j < tol.GetLength(0); j++) //vnitřní cyklus po řádcích
                {
                    if (tol[j, i] == pop)
                    {
                        pocitadlo_aktu++; //zvyšování pomocného počitadla
                    }
                }
                if(pocitadlo_aktu > pocitadlo_max)
                {
                    indexPop = i; //uložení indexu sloupce nově nalezeného nejpopulárnějšího souseda
                    pocitadlo_max = pocitadlo_aktu;
                }
                pocitadlo_aktu = 0;
            }
            return indexPop;
        }
    }
}
