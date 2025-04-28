using Dedicnost_Uvod;

namespace Dedicnost_Konstruktor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human clovicek = new Human("Hanz", 24);
            clovicek.IdentifySelf();

            Student zacek = new Student("Jaroslav", 12, "2.A", [1, 5, 1]);
            //jeho metoda IdentifySelf() byla přepsaná, proto udělá jiný výpis než u ostatních tříd
            zacek.IdentifySelf();

            Teacher ucitel = new Teacher("Petr", 45, ["Matika", "Čeština"], 125);
            ucitel.IdentifySelf();
            ucitel.Teaching();
        }
    }
}
