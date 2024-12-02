namespace Proc_PodminenySoucet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Incializace pole s hodnotami
            int[] cisla = { 25, -56, -88, 5, 10, 65, 584, -8, -120, 186 };
            int soucet = 0;

            foreach (int cislo  in cisla) //průchod polem
            {
                if(cislo > -10 && cislo < 10) //kontrola 
                {
                    soucet += cislo; //přičtení hodnoty k součtu
                }
            }

            Console.WriteLine(soucet);
        }
    }
}
