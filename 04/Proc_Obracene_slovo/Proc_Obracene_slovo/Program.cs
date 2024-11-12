namespace Proc_Obracene_slovo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string slovo = "les pes kaluž";

            for (int i = slovo.Length-1; i >= 0; i--)
            {
                Console.Write(slovo[i]);
            }
        }
    }
}
