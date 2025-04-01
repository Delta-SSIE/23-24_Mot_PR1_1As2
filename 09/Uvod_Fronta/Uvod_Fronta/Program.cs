namespace Uvod_Fronta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fronta = new Queue<string>();
            
            //přidání prvků do fronty - přidávají se přes back na front
            fronta.Enqueue("Jaromír");
            fronta.Enqueue("Ruprecht");
            fronta.Enqueue("Gustav");

            //vypsání
            foreach (string jmeno in fronta)
            {
                Console.Write(jmeno + " ");
            }
            Console.WriteLine("-------");

            //Vyhození prvního prvku na frontu fronty
            fronta.Dequeue();
            foreach (string jmeno in fronta)
            {
                Console.Write(jmeno + " ");
            }
            Console.WriteLine("-------");


            //hledání prvku ve frontě
            Console.WriteLine(fronta.Contains("Gustav"));
            Console.WriteLine(fronta.Contains("Jaromír"));

            //peek - podívá se na první prvek na frontu fronty
            Console.WriteLine(fronta.Peek());
            
            //Zařazení prvního prvku na konec fronty
            fronta.Enqueue(fronta.Dequeue());
            foreach (string jmeno in fronta)
            {
                Console.Write(jmeno + " ");
            }
            Console.WriteLine("-------");
        }
    }
}
