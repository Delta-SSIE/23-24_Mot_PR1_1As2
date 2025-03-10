namespace Zapouzdreni_BankovniUcty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ucet mujUcet = new Ucet();
            mujUcet.Bilance = 200;
            mujUcet.JmenoVlastnika = "Jan Záruba";
            int vyber = 0;

            while (true)
            {
                Console.WriteLine($"Vlastník účtu: {mujUcet.JmenoVlastnika}");
                Console.WriteLine($"Zůstatek na účtu: {mujUcet.Bilance}");
                Console.WriteLine("Pro výběr napiš 1; Pro vklad napiš 2");
                try
                {
                    vyber = int.Parse(Console.ReadLine());
                } catch
                {
                    Console.WriteLine("Zadaná jiná hodnota než číslo");
                }
                double castka = 0;
                switch (vyber)
                {
                    case 1:
                        Console.WriteLine("Kolik chceš vybrat");
                        castka = double.Parse(Console.ReadLine());
                        mujUcet.Bilance -= castka;
                        break;
                    case 2:
                        Console.WriteLine("Kolik chceš vložit");
                        castka = double.Parse(Console.ReadLine());
                        mujUcet.Bilance += castka;
                        break;
                    default:
                        Console.WriteLine("Tato možnost neexistuje");
                        break;
                }
            }
        }
    }
}
