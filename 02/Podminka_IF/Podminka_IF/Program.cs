namespace Podminka_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;

            //Podmínka if rovnost a nerovnost
            if (x == 5) // == je rovnost
            {
                Console.WriteLine("Hodnota proměnné X je 5");
            }
            if (y != 5) // =! je nerovnost
            {
                Console.WriteLine("Hodnota proměnné Y není 5");
            }

            //Podmínka if větší a menší
            Console.WriteLine("Kolik ti je let?");
            int age = int.Parse(Console.ReadLine());

            if(age >= 18) // age je vyšší, nebo rovno 18
            {
                Console.WriteLine("Jsi dle zákona dospělý!");
            }
            if (age < 18) // age je menší než 18
            {
                Console.WriteLine("Dle zákona nejsi dospělý!");
            }

            //Podmínka if s logickými operátory
            Console.WriteLine("Kolik ti je let?");
            int age2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Máš řidičák? (Y/N)");
            string odpoved = Console.ReadLine();

            if((age2 >= 18) && (odpoved == "Y")) //(&& == AND) – pokud age2 je vyšší nebo rovno 18 A ZAROVEN odpoved se rovná "Y"
            {
                Console.WriteLine("Gratuluji! Jsi dospělý a můžeš řídit auto!");
            }


            if ((age2 >= 18) || (odpoved == "Y")) //(|| == OR) – pokud age2 je vyšší nebo rovno 18 NEBO odpoved se rovná "Y"
            {
                Console.WriteLine("Gratuluji! Jsi dospělý nebo můžeš řídit auto!");
            }

            if((age2 >= 18) && !(odpoved == "N")) //(! == Not) – pokud age2 je vyšší nebo rovno 18 A ZAROVEN NENI odpoved rovna "N"
            {
                Console.WriteLine("Gratuluji! Jsi dospělý a můžeš řídit auto! (NOT možnost)");
            }

            //Podmínka a větvení na kladnou a zápornou větev pomocí ELSE

            Console.WriteLine("Máš rád borůvky? (Y/N)");
            char odpoved2 = Console.ReadKey().KeyChar; //vezme pouze jeden znak

            if (odpoved2 == 'Y')
            {
                Console.WriteLine("Gratuluji! To si dáš koláč je totiž borůvkový!"); ;
            } else
            {
                Console.WriteLine("To je škoda, to si koláč s nimi nedáš!");
            }

            //Podmínka a větvení na kladnou a zápornou větev pomocí ELSE IF
            Console.WriteLine("Máš rád borůvky? (Y/N)");
            char odpoved4 = Console.ReadKey().KeyChar; //vezme pouze jeden znak
            Console.WriteLine("Máš rád tvaroh? (Y/N)");
            char odpoved5 = Console.ReadKey().KeyChar; //vezme pouze jeden znak


            if (odpoved4 == 'Y' && odpoved5 == 'Y')
            {
                Console.WriteLine("Gratuluji! To si dáš koláč tvarohový i borůvkový!"); ;
            }
            else if(odpoved4 == 'Y')
            {
                Console.WriteLine("Gratuluji! To si dáš koláč borůvkový!"); ;
            } else if (odpoved5 == 'Y')
            {
                Console.WriteLine("Gratuluji! To si dáš koláč tvarohový!"); ;
            } else
            {
                Console.WriteLine("Tak to nebudeš jíst!"); ;
            }



            //Short-hand if (zkrácený zápis podmínky
            Console.WriteLine("Jaký je čas?");
            int odpoved3 = int.Parse(Console.ReadLine());
            //Podmínka zapsaná jako zkratka
            //(odpoved3 >= 18) podmínka označená znamínkem "?"
            //"Dobrý večer" : "Dobrý den" kladný a záporný output
            Console.WriteLine((odpoved3 >= 18) ? "Dobrý večer" : "Dobrý den");





        }
    }
}
