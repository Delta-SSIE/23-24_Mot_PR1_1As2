namespace Proc_DelkaSlova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej mi 1.slovo: ");
            string slovo1 = Console.ReadLine();
            Console.Write("Zadej mi 2.slovo: ");
            string slovo2 = Console.ReadLine();

            if(slovo1.Length == slovo2.Length) //string.Length vrací délku textového řetězce
            {
                Console.WriteLine("Slova jsou stejně dlouhá");
            } else if (slovo1.Length > slovo2.Length) 
            {
                Console.WriteLine($"1. slovo: {slovo1} je delší než 2. slovo: {slovo2}.");
            } else
            {
                Console.WriteLine($"2. slovo: {slovo2} je delší než 1. slovo: {slovo1}.");

            }

        }
    }
}
