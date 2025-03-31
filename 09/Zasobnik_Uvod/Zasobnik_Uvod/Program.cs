namespace Zasobnik_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //deklarace zásobniku
            Stack<string> jmena = new Stack<string>();

            //přidání prvků do zásobníku
            jmena.Push("Kamil");
            jmena.Push("Jindra");
            jmena.Push("Ruprecht");
            jmena.Push("Jarmila");
            jmena.Push("Ivana");

            //průchod
            foreach (string jmeno in jmena)
            {
                Console.WriteLine(jmeno);
            }
            Console.WriteLine("--------------");
            //peek - ukáže se první prvek na vrcholu zásobníku
            Console.WriteLine(jmena.Peek());

            //FIFO - first in, first out
            jmena.Pop(); //vyhodí první prvek = Ivana
            jmena.Pop(); //vyhodí nový první prvek = Jarmila
            Console.WriteLine("--------------");
            //peek - ukáže se první prvek na vrcholu zásobníku
            Console.WriteLine(jmena.Peek()); //Ruprecht


        }
    }
}
