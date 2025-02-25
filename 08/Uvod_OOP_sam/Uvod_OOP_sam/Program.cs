namespace Uvod_OOP_sam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lide person = new Lide("Jacob",22);

            /*
            person.name = "Jacob";
            person.age = 35;
            */

            person.Introduction();

            Lide person2 = new Lide("Johnathan", 15);
            person2.Introduction();
        }
    }
}
