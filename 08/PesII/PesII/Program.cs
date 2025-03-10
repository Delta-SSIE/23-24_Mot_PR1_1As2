namespace PesII
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pes lord = new Pes();
            lord.Jmeno = "Lord Super";
            lord.Nohy = 1;
            lord.JeOckovany = true;

            Console.WriteLine(lord.PredstavSe());


            Pes podvratak = new();
            podvratak.Jmeno = "Dobrý kamarád Vořech";
            podvratak.Nohy = 4;
            podvratak.JeOckovany = false;

            Console.WriteLine(podvratak.PredstavSe()); ;
        }
    }
}
