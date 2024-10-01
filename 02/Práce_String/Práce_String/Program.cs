namespace Práce_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "ABCDEFGijk C";

            //string.Lenght vrací délku daného řetězce
            Console.WriteLine(a.Length);

            //Výpis stringu jenom ve velkých, či malých písmenech
            Console.WriteLine(a.ToUpper());
            Console.WriteLine(a.ToLower());

            //Indexování znaků ve stringu
            Console.WriteLine(a[1]); //ve stringu "a" na indexu 1 (tzn. znak B)
            Console.WriteLine(a[0]); //ve stringu "a" na indexu 0 (tzn. znak A)
            Console.WriteLine(a[10]); //ve stringu "a" na indexu 10 (tzn. znak " ")

            //lze takto převést string na konkrétní char
            char pismeno = a[0];
            Console.WriteLine(pismeno);

            //Lze naopak najít index konkrétního výskytu znaku (prvního výskytu ve stringu)
            Console.WriteLine(a.IndexOf("C")); //IndeOf(znak,který hledáme)
            Console.WriteLine(a.Substring(4).IndexOf("C")); //Substring začne indexovat od konkrétního indexu, který je pak považován jako index 0

            //Speciální znaky
            Console.WriteLine("\"text v dvojitých uvozovkách\" ");
            Console.WriteLine("\'text v jednoduchých uvozovkách\'");
            Console.WriteLine("\\"); //dvě zpětné lomítka pro zobrazeního jednoho
            Console.WriteLine("Text jednoho řádku \nText druhého řádku"); //lomítko \n pro nový řádek



        }
    }
}
