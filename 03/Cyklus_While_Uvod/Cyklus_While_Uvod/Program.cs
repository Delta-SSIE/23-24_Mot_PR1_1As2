namespace Cyklus_While_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiš do kolika chceš, abych počítal");
            int cislo = int.Parse(Console.ReadLine());

            //počítadlo
            int pocitadlo = 1;

            //Cyklus while
            while (pocitadlo <= cislo) //podmínka cyklu
                //Dokud pocitadlo je menší, či rovno cislo, tak opakuj
            {
                Console.Write(pocitadlo + " ");
                pocitadlo++; //zvednutí pocitadla o 1
            }
            Console.WriteLine();

            //Cyklus DoWhile - příklad robot, co kupuje colu
            int cenaColy = 35; //cena coca-coly
            int automat = 0; //součet mincí vhozených do automatu
            int mince = 0; //mince, kterou robot drží v ruce
            Random gen = new Random(); //generátor náhodných čísel

            do //tělo cyklu
            {
                do
                {
                    mince = gen.Next(1, 51); //1–50
                } while (mince != 1 && mince != 2 && mince != 5 && mince != 10 && mince != 20 && mince != 50); //podmínka limituje, aby se načetla do proměnné jedna z vybraných hodnot
                Console.WriteLine($"Robot vhodil minci {mince}");
                automat += mince; //hodnota mince se přidá k tomu, co je v automatu
            } while (automat < cenaColy); //podmínka (dokud je v automatu méně mincí, než je cena coly)

            Console.WriteLine($"Vypadla Cola! Vypadlo: {automat-cenaColy}");
        }
    }
}
