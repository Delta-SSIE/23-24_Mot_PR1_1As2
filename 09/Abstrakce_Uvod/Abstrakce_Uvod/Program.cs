namespace Abstrakce_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Třída Human je abstraktní to znamená, že z ní nelze vytvářet objekty a lze pouze aby jiné třídy dědili z ní.
            Human clovicek = new Human("Hanz", 24);
            clovicek.IdentifySelf
            */

            Student zacek = new Student("Jaroslav", 12, "2.A", [1, 5, 1]);
            //jeho metoda IdentifySelf() byla přepsaná, proto udělá jiný výpis než u ostatních tříd
            zacek.IdentifySelf();
            zacek.Talk();

            Teacher ucitel = new Teacher("Petr", 45, ["Matika", "Čeština"], 125);
            ucitel.IdentifySelf();
            ucitel.Teaching();
            ucitel.Talk();
        }
    }
}
