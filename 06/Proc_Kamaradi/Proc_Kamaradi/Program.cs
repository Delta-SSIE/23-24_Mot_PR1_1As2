namespace Proc_Kamaradi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zavolání metod s dvěma argumenty, pokaždé s jinými
            Kamaradi("Pepa", "Karel");
            Kamaradi("Josefína", "Libuše");
            Kamaradi("Adolf", "Herman");
        }

        //Metoda s dvěma parametry string
        static void Kamaradi(string kamarad1, string kamarad2)
        {
            Console.WriteLine($"Moji kamarádi jsou {kamarad1} a {kamarad2}.");
        }
    }
}
