namespace For_cyklus_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0 /*stane se jednou na začátku cyklu*/; i < 10 /*podmínka, co se ověřuje
                 při každém průchodu cyklu*/; i++ /* stane se na konci každého průchodu tělem cyklu*/)
            {
                Console.WriteLine(i);
            }

            //bez komentářů
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int vstup = int.Parse(Console.ReadLine());

            for (int i = 0; i < vstup; i++)
            {
                Console.WriteLine(i);
            }

            //Dva cykly v sobě
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i}*{j}={i*j}");
                }
            }


        }
    }
}
