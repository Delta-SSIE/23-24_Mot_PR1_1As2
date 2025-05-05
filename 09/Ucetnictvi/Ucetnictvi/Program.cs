namespace Ucetnictvi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "John";

            Dictionary<string, List<Invoice>> monthlyInvoices = new();
            Random gen = new Random();


            string[] months = new string[]
            { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

            for (int i = 0; i < months.Length; i++)
            {
                monthlyInvoices.Add(months[i], new List<Invoice>());
                monthlyInvoices[months[i]].Add(new ElectricityInvoice(name, gen.Next(20,500)));
                monthlyInvoices[months[i]].Add(new InternetInvoice(name, gen.Next(50, 250)));
                monthlyInvoices[months[i]].Add(new FreelanceInvoice(name, gen.Next(0, 15)));
            }

            //File.Create("faktura.txt");

            StreamWriter sw = new StreamWriter("faktura.txt");

            for (int i = 0; i < monthlyInvoices.Count; i++)
            {
                double sumpricemonth = 0;
                for (int j = 0; j < monthlyInvoices[months[i]].Count; j++)
                {
                    sumpricemonth += monthlyInvoices[months[i]][j].CalculateTotal();
                }
                sw.WriteLine($"{months[i]} : {sumpricemonth} ");
                for (int j = 0; j < monthlyInvoices[months[i]].Count; j++)
                {
                    sw.WriteLine(monthlyInvoices[months[i]][j].CalculateTotal());
                }
            }

            sw.Close();





        }
    }
}
