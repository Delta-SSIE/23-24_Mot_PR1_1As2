namespace Switch_Zaklad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej mi číslo měsíce? ");
            int mesic = int.Parse(Console.ReadLine());

            switch(mesic) //Switch se zabývá vždy hodnotou proměnné
            {
                case 12: //v rámci každého casu poměřuje hodnotu proměnné s proměnnou zapsanou zde
                    Console.WriteLine("Zima");
                    break;
                case 1:
                    Console.WriteLine("Zima");
                    break;
                case 2:
                    Console.WriteLine("Zima");
                    break;
                case 3:
                    Console.WriteLine("Jaro");
                    break;
                case 4:
                    Console.WriteLine("Jaro");
                    break;
                case 5:
                    Console.WriteLine("Jaro");
                    break;
                case 6:
                    Console.WriteLine("Léto");
                    break;
                case 7:
                    Console.WriteLine("Léto");
                    break;
                case 8:
                    Console.WriteLine("Léto");
                    break;
                case 9:
                    Console.WriteLine("Podzim");
                    break;
                case 10:
                    Console.WriteLine("Podzim");
                    break;
                case 11:
                    Console.WriteLine("Podzim");
                    break;
                default: //spustí se vždycky, pokud hodnota proměnné neodpovídá žádnému casu
                    Console.WriteLine("Zadal jsi nesmyslné číslo");
                    break;
            }

        }
    }
}
