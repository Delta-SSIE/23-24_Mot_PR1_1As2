namespace Proc_SudaLicha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej mi číslo ");
            int cislo = int.Parse(Console.ReadLine());
            if (cislo == 0) //pro odchycení nuly hned na začátku podmínky
            {
                Console.WriteLine("Číslo je NULA!");
            }
            else if(cislo % 2 == 0) //modulo "%" – Zbytek po celočíselném dělení čísla se rovná 0
            {
                Console.WriteLine("Číslo je SUDÉ!");
            } else
            {
                Console.WriteLine("Číslo je LICHÉ!");
            }
        }
    }
}
