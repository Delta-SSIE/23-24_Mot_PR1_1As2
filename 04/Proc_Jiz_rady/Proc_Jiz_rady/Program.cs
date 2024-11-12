namespace Proc_Jiz_rady
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minuty = 342;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"{minuty/60}:{minuty%60} {i+1}.Autobus");
                minuty += 13;
            }
        }
    }
}
