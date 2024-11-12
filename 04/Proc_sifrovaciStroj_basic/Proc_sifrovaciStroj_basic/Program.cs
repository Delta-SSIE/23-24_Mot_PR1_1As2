namespace Proc_sifrovaciStroj_basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej mi text na zašifrování");
            string text = Console.ReadLine();
            string zasifrovano = "";
            string desifrovano = "";

            for (int i = text.Length-1; i >= 0; i--)
            {
                switch (text[i])
                {
                    case 'a':
                        zasifrovano += '#';
                        break;
                    case 'o':
                        zasifrovano += '$';
                        break;
                    case 'i':
                        zasifrovano += '&';
                        break;
                    default:
                        zasifrovano += text[i];
                        break;
                }
            }

            Console.WriteLine(zasifrovano);

            for (int i = zasifrovano.Length - 1; i >= 0; i--)
            {
                switch (zasifrovano[i])
                {
                    case '#':
                        desifrovano += 'a';
                        break;
                    case '$':
                        desifrovano += 'o';
                        break;
                    case '&':
                        desifrovano += 'i';
                        break;
                    default:
                        desifrovano += zasifrovano[i];
                        break;
                }
            }
            Console.WriteLine(desifrovano);
        }
    }
}
