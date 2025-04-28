namespace Dedicnost_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human clovek = new Human
            {
                name = "John",
                age = 10
            };

            clovek.IdentifySelf();

            // Vytvoření objektu z třídy Student, kde tato třída dědí ze třídy Human
            //name a age jsou dané třídou Human, zatímco grade a mark udává třída Student
            Student zak = new Student
            {
                name = "Ruprecht",
                age = 14,
                grade = "3.A",
                mark = [ 1, 5, 3, 1]
            };

            zak.IdentifySelf();

            Console.WriteLine(zak.grade);
            //Human nezná grade, to zná pouze Student
            //Console.WriteLine(clovek.grade);

            //Tvorba objektu z třídy Teacher

            Teacher ucitel = new Teacher
            {
                name = "Ondřej",
                age = 45,
                cislo_kab = 105,
                subjects = ["Math", "Science"]
            };

            ucitel.IdentifySelf();
            ucitel.Teaching();

            /* clovek ani zak neznají metodu Teaching, tu mají pouze objekty z třídy Teacher
            clovek.Teaching;
            źak.Teaching();
            */

        }
    }
}
