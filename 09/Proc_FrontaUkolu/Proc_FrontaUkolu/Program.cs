namespace Proc_FrontaUkolu
{
    internal class Ukol
    {
        public int Id { get; set; }
        public string Priorita { get; set; }

        public Ukol(int id, string priorita)
        {
            Id = id;
            Priorita = priorita;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicializace počáteční fronty úkolů
            Queue<Ukol> frontaUkolu = new Queue<Ukol>();
            frontaUkolu.Enqueue(new Ukol(1, "vysoká"));
            frontaUkolu.Enqueue(new Ukol(2, "střední"));
            frontaUkolu.Enqueue(new Ukol(3, "nízká"));
            frontaUkolu.Enqueue(new Ukol(4, "vysoká"));
            frontaUkolu.Enqueue(new Ukol(5, "střední"));

            // Inicializace další počáteční fronty úkolů
            Queue<Ukol> dalsiFrontaUkolu = new Queue<Ukol>();
            dalsiFrontaUkolu.Enqueue(new Ukol(6, "nízká"));
            dalsiFrontaUkolu.Enqueue(new Ukol(7, "střední"));
            dalsiFrontaUkolu.Enqueue(new Ukol(8, "vysoká"));
            dalsiFrontaUkolu.Enqueue(new Ukol(9, "střední"));
            dalsiFrontaUkolu.Enqueue(new Ukol(10, "nízká"));

            // Zde bude volání metody pro zpracování úkolů ve frontě
            ZpracovatUkolyVeFronte(frontaUkolu);
            ZpracovatUkolyVeFronte(dalsiFrontaUkolu);
        }

        static void ZpracovatUkolyVeFronte(Queue<Ukol> seznam)
        {
            string[] priority = { "vysoká", "střední", "nízká" };
            Queue<Ukol> novyseznam = new Queue<Ukol>();

            for (int i = 0; i < priority.Length; i++)
            {
                    foreach(Ukol ukol in seznam)
                    {
                        if(ukol.Priorita == priority[i])
                        {
                            novyseznam.Enqueue(ukol);
                        }
                    }
            }

            while(novyseznam.Count > 0)
            {
                Ukol vyhozen = novyseznam.Dequeue();
                Console.WriteLine($"Splněn úkol {vyhozen.Id} s prioritou {vyhozen.Priorita}");
            }
        }
    }
}
