namespace Proc_Sestistenka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random cislo = new Random();

            int hod = cislo.Next(1, 7); //1-6

            switch (hod)
            {
                case 1:
                    Console.WriteLine("Padla jednička!");
                    break;
                case 2:
                    Console.WriteLine("Padla dvojka!");
                    break;
                case 3:
                    Console.WriteLine("Padla trojka!");
                    break;
                case 4:
                    Console.WriteLine("Padla čtyřka!");
                    break;
                case 5:
                    Console.WriteLine("Padla pětka!");
                    break;
                case 6:
                    Console.WriteLine("Padla šestka!");
                    break;
            }
        }
    }
}
