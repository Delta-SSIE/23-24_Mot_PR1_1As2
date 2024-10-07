namespace JeSamohlaska
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Stiskni klávesu ");
            char znak = Console.ReadKey().KeyChar; //načtení znaku po stisknutí klávesy
            Console.WriteLine();

            // i, í, e, é, a, á, o, ó, u, ú - samohlásky
            if (znak == 'i' || znak == 'í' || znak == 'e' || znak == 'é' || znak == 'a' || znak == 'á'
                || znak == 'o' || znak == 'ó' || znak == 'u' || znak == 'ú') 
            {
                Console.WriteLine("Zadaný znak je samohláska");
            } else
            {
                Console.WriteLine("Zadaný znak není samohláska");
            }
        }
    }
}
