namespace _2DPole_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklarace Vícerozměrného pole
            int[,] dvou_pole; //2D pole
            int[,,] troj_pole; //3D pole

            //Deklarace 2D pole o určité velikosti
            int[,] def_pole = new int[6, 3]; //2D pole o 6 řádcích a 3 sloupcích

            //Deklarace 2D pole s hodnotami
            int[,] d2pole = { { 50, 100, 300, 40 }, { 5, 10, 100, 50 }, { 0, 1, 3, 4 } };
            //Předefinované pole s hodnotami, kdy jednotlivé řádky jsou uvozeny {}
            /*
             * 50, 100, 300, 40
             * 5,   10, 100, 50
             * 0,    1,   3,  4
             */

            //Výpis prvku z pole
            Console.WriteLine(d2pole[1,2]);
            //Při volání je nutno nejdříve zadat index řádku (v našem případě 1) a pak index sloupce (v našem případě 2) ==> 100
            Console.WriteLine(d2pole[2,3]);
            //2 řádek a 3 sloupec ==> 4
            Console.WriteLine(d2pole[0,1]);
            //0. řádek a 1. sloupec ==> 100

            //Přepis hodnoty na konkrétním řádku
            d2pole[0, 0] = 3000; //přepíše hodnotu na 0. řádku a 0. sloupci, neboli změní 50 na 3000

            ///Výpis z 2D pole
            foreach (int cislo in d2pole)
            {
                Console.Write(cislo + " ");
            }
            /*
             * Foreach
             * Načítání prvky po řádcích, následně vypisuje hodnoty na řádku a pak poskočí o řádek dál!
             */
            Console.WriteLine();

            //Počet prvků
            Console.WriteLine(d2pole.Length); //Vrací počet prvků v poli ==> 12
            Console.WriteLine("Počet řádků je "+d2pole.GetLength(0)); //Vrací počet řádků
            Console.WriteLine("Počet sloupců je "+d2pole.GetLength(1)); //Vrací počet sloupců

            //Výpis z 2D pole pomocí for cyklů
            for (int i = 0; i < d2pole.GetLength(0); i++) //Vnější cyklus pro průchod po řádcích
            {
                Console.Write($"{i+1}. řádek: ");
                for (int j = 0; j < d2pole.GetLength(1); j++) //Vnitřní cyklus pro průchod po sloupcích 
                {
                    Console.Write(d2pole[i,j] + " "); //vypsaní prvku
                    //i je počitadlo řádků a j je počitadlo sloupců
                }
                Console.WriteLine(); //na konci každého řádku je třeba zalomit
            }
        
        }
    }
}
