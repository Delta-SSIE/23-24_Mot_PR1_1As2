namespace Proc_DelkaRetezcu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] slova = new string[5]; //deklarace pole o délce 5

            for (int i = 0; i < slova.Length; i++)
            {
                Console.WriteLine($"{i+1}. slovo: ");
                slova[i] = Console.ReadLine();
            }

            Console.Write("Zde vypisuji slova, která mají alespoň 6 znaků: ");
            foreach (string slovo in slova)
            {
                if(slovo.Length >= 6)
                {
                    Console.Write(slovo + ", ");
                }
            }
            Console.WriteLine();
        }
    }
}
