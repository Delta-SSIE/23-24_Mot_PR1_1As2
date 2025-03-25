namespace List_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklarace nového listu
            List<string> seznamHostu = new List<string>();

            //Deklarace listu int s kapacitou 10
            List<Int32> cislaDomu = new List<int>(10);

            //zavolání kapacitu listu
            Console.WriteLine(seznamHostu.Capacity); //má 0, protože se jeho kapacita odvijí od velikosti
            Console.WriteLine(cislaDomu.Capacity); //má 10, protože jeho kapacita je definovaná

            //Vložení prvku do listu
            seznamHostu.Add("Jakub Narožný");
            seznamHostu.Add("Václav Bodický");
            seznamHostu.Add("Juraj Blecha");

            cislaDomu.Add(10);
            cislaDomu.Add(20);

            //zavolání počtu prvků v listech
            Console.WriteLine(seznamHostu.Count());
            Console.WriteLine(cislaDomu.Count());

            //Vkládání pole do listu
            int[] cisla = { 50, 100, 200 };
            //AddRange pro přidání pole
            cislaDomu.AddRange(cisla);
            Console.WriteLine(cislaDomu.Count());

            //průchod listem
            foreach(string jmeno in seznamHostu)
            {
                Console.WriteLine(jmeno);
                // jmeno = ""; nelze měnit hodnoty v listu v rámci foreache
            }

            //indexování prvků v listu
            Console.WriteLine(seznamHostu[0]);
            seznamHostu[0] = "Václav Potůček"; //přes index lze přepsat´hodnota
            Console.WriteLine(seznamHostu[0]);

            //Vkládání prvku na konkrétní místo (další prvky se posunou
            seznamHostu.Insert(0, "Lukáš Muller");
            foreach (string jmeno in seznamHostu)
            {
                Console.WriteLine(jmeno);
            }

            string[] hoste = { "Lucie Líbalová", "Alžběta Brodská", "Ignácie Rumunská" };
            seznamHostu.InsertRange(1, hoste); //vložím seznam od indexu 1 dál, pak pokračuje starý seznam
            foreach (string jmeno in seznamHostu)
            {
                Console.WriteLine(jmeno);
            }

            //Mazaní prvků z listu
            seznamHostu.Remove("Lukáš Muller"); //konkrétní hodnota
            foreach (string jmeno in seznamHostu)
            {
                Console.WriteLine(jmeno);
            }

            seznamHostu.RemoveAt(0); //smaže prvku na 0 indexu
            foreach (string jmeno in seznamHostu)
            {
                Console.WriteLine(jmeno);
            }
            Console.WriteLine("---------------");
            seznamHostu.RemoveRange(0, 2);
            foreach (string jmeno in seznamHostu)
            {
                Console.WriteLine(jmeno);
            }

            //hledání indexu daného prvku
            Console.WriteLine(seznamHostu.IndexOf("Juraj Blecha"));
            Console.WriteLine(seznamHostu.IndexOf("Jan Blecha")); //pokud prvek neexistuje v seznamu, vrací -1

            seznamHostu.Add("Juraj Blecha");
            seznamHostu.Add("Juraj Blecha");
            Console.WriteLine("---------------");
            foreach (string jmeno in seznamHostu)
            {
                Console.WriteLine(jmeno);
            }
            Console.WriteLine(seznamHostu.IndexOf("Juraj Blecha")); //první výskyt v seznamu
            Console.WriteLine(seznamHostu.LastIndexOf("Juraj Blecha")); //poslední výskyt v seznamu

            seznamHostu.Sort(); //řadí dle abecedy
            Console.WriteLine("---------------");
            foreach (string jmeno in seznamHostu)
            {
                Console.WriteLine(jmeno);
            }
            seznamHostu.Reverse(); //řadí obráceně
            Console.WriteLine("---------------");
            foreach (string jmeno in seznamHostu)
            {
                Console.WriteLine(jmeno);
            }

            Console.WriteLine(seznamHostu.BinarySearch("Juraj Blecha"));



        }
    }
}
