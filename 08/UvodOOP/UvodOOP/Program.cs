namespace UvodOOP
{ 
    //třída Auta
    class Auta
    {
        //Vlastnosti a metody musí být PUBLIC, abych je mohl využívat v jiné třídě!

        //vlastnosti/atributy --> ty budou mít všechny objekty vytvořené z této třídy
        public int kola = 4;
        public string znacka = "BMW";

        //metoda --> každý objekt vytvořený z této třídy bude umět tuto metodu
        public void Zatrub()
        {
            //v rámci metody využívám konkrétní hodnotu objektu dané třídy
            Console.WriteLine($"áááááááááá! Tahle troubí auto s {this.kola} koly.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //a1 je nový objekt vzniklý ze třídy Auta
            Auta a1 = new Auta();

            //Výpis vlastnosti z objektu
            Console.WriteLine(a1.kola);
            a1.kola = 0; //změna hodnoty na vlastnosti kola
            Console.WriteLine(a1.kola);

            Auta b1 = new Auta(); //nový objekt ze třídy Auta 
            Console.WriteLine(b1.kola); //vypsání 

            //zavolání metody daného objektu
            a1.Zatrub();
            b1.Zatrub();

        }
    }
}
