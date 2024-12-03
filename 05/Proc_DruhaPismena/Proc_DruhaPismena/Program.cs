namespace Proc_DruhaPismena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Statný valach ojnici zničil. Révou zhrdla žena ostrovana Claudia Pompeia. Ozvučení hnědé místnosti okamžitě zvýraznit! Běžný statkář to zvládne. Japonec Anihito rád označoval čárami. Asi sto pět kravských žaludků";
            string[] slova = text.Split(' '); //oddělovač pro rozdělení prvků v poli je mezera

            foreach (string slovo in slova)
            {
                Console.Write(slovo[1]);
            }

            
        }
    }
}
