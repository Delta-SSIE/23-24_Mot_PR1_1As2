namespace Ceasarova_sifra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Základní verze
            string text = "bipk upimf kf ubkob aqsbwb dp nvtjt spamvtuju";
            string des_text = "";

            for (int i = 0; i < text.Length; i++)
            {
                int cislo_znaku = text[i];
                if (cislo_znaku == 97)
                {
                    cislo_znaku = 122;
                    char novy_znak = (char)cislo_znaku;
                    des_text += novy_znak;
                } else if (cislo_znaku == 32)
                {
                    des_text += text[i];
                } else
                {
                    cislo_znaku--;
                    char novy_znak = (char)cislo_znaku;
                    des_text += novy_znak;
                }
              
            }

            Console.WriteLine(des_text);

            string zas_text = "";

            for (int i = 0; i < des_text.Length; i++)
            {
                int cislo_znaku = des_text[i];
                if (cislo_znaku == 122)
                {
                    cislo_znaku = 97;
                    char novy_znak = (char)cislo_znaku;
                    zas_text += novy_znak;
                }
                else if (cislo_znaku == 32)
                {
                    zas_text += text[i];
                }
                else
                {
                    cislo_znaku++;
                    char novy_znak = (char)cislo_znaku;
                    zas_text += novy_znak;
                }

            }

            Console.WriteLine(zas_text);
            */

            //Pokročilá verze
            string text = "dyrvo to woqk dktxk jzbkfk my xsuny xocws jscukd";
            string des_text = "";
            int posun = 10;

            for (int i = 0; i < text.Length; i++)
            {
                int cislo_znaku = text[i];
                if (cislo_znaku == 32) // 32 je mezera
                {
                    des_text += text[i];
                }
                else
                {
                    cislo_znaku -= posun;
                    if (cislo_znaku < 97)
                    {
                        cislo_znaku += 26;
                    }
                    char novy_znak = (char)cislo_znaku;
                    des_text += novy_znak;
                }

            }

            Console.WriteLine(des_text);
            string zas_text = "";

            for (int i = 0; i < des_text.Length; i++)
            {
                int cislo_znaku = des_text[i];
                if (cislo_znaku == 32) // 32 je mezera
                {
                    zas_text += des_text[i];
                }
                else
                {
                    cislo_znaku += posun;
                    if (cislo_znaku > 122)
                    {
                        cislo_znaku -= 26;
                    }
                    char novy_znak = (char)cislo_znaku;
                    zas_text += novy_znak;
                }

            }
            Console.WriteLine(zas_text);
        }
    }
}
