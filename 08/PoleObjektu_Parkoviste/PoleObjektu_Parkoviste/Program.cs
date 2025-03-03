namespace PoleObjektu_Parkoviste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Auto moje_auto = new Auto();
            moje_auto.Znacka = "Audi";
            */

            /*
            Auto moje_auto = new Auto()
            {
                Znacka = "Audi",
                Barva = "Červená"
            };
            */

            //testovací objekt z využitím konstruktoru
            Auto testAuto = new Auto(4); //4 je argument pro parametr pocet
            //Console.WriteLine(testAuto.Indetifikuj());

            //Pole objektů
            //Vytvoření pole objektů ze třídy Auto s velikostí 50
            Auto[] parkoviste = new Auto[1000];

            //Naplnění pole objektů objekty
            for (int i = 0; i < parkoviste.Length; i++)
            {
                parkoviste[i] = new Auto(4); //4 kola pro každé auto
            }

            //Výpis aut na parkovišti
            /*
            for (int i = 0; i < parkoviste.Length; i++)
            {
                Console.WriteLine(parkoviste[i].Indetifikuj()); 
            }
            */

            //Na parkoviště přijede polcajt, který dá pokutu všem Subaru
            for (int i = 0; i < parkoviste.Length; i++)
            {
                if (parkoviste[i].Znacka == "Subaru")
                {
                    parkoviste[i].Pokuta = true; //dá mu pokutu
                }
            }

            //Na parkoviště přijede zloděj, který všem autům s barvou oranžovou seber jedno kolo
            for (int i = 0; i < parkoviste.Length; i++)
            {
                if (parkoviste[i].Barva == "Orange")
                {
                    parkoviste[i].Kola--; //snížení hodnoty vlastnosti Kola o 1
                }
            }

            //Chci vypsat všechna auta, která mají pokutu, nebo nemají 4 kola
            for (int i = 0; i < parkoviste.Length; i++)
            {
                if (parkoviste[i].Pokuta || parkoviste[i].Kola < 4)
                {
                    Console.WriteLine(parkoviste[i].Indetifikuj());
                }
            }
        }
    }
}
