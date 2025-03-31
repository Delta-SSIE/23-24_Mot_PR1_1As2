using System.Security.Cryptography.X509Certificates;

namespace Proc_Knihovna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Book> knihovna = new Dictionary<string, Book>();
            knihovna.Add("978-3-16-148410-0", new Book("To Kill a Mockingbird", "Harper Lee"));
            knihovna.Add("978-1-4028-9462-6", new Book("1984", "George Orwell"));
            knihovna.Add("978-0-596-52068-7", new Book("Pride and Prejudice", "Jane Austen"));
            knihovna.Add("978-0-201-63361-0", new Book("The Great Gatsby", "F. Scott Fitzgerald"));
            knihovna.Add("978-0-262-13472-9", new Book("Moby Dick", "Herman Melville"));
            knihovna.Add("978-0-387-95041-9", new Book("War and Peace", "Leo Tolstoy"));
            knihovna.Add("978-0-521-85033-5", new Book("The Catcher in the Rye", "J.D. Salinger"));
            knihovna.Add("978-0-07-032448-0", new Book("The Hobbit", "J.R.R. Tolkien"));
            knihovna.Add("978-0-13-110362-7", new Book("Crime and Punishment", "Fyodor Dostoevsky"));
            knihovna.Add("978-0-262-03384-8", new Book("Brave New World", "Aldous Huxley"));
            knihovna.Add("978-0-471-48648-0", new Book("The Odyssey", "Homer"));
            knihovna.Add("978-0-387-98771-2", new Book("The Iliad", "Homer"));
            knihovna.Add("978-0-521-85034-2", new Book("Jane Eyre", "Charlotte Brontë"));
            knihovna.Add("978-0-07-032449-7", new Book("Wuthering Heights", "Emily Brontë"));
            knihovna.Add("978-0-13-110363-4", new Book("The Divine Comedy", "Dante Alighieri"));
            knihovna.Add("978-0-262-03385-5", new Book("The Brothers Karamazov", "Fyodor Dostoevsky"));
            knihovna.Add("978-0-471-48649-7", new Book("Les Misérables", "Victor Hugo"));
            knihovna.Add("978-0-387-98772-9", new Book("Anna Karenina", "Leo Tolstoy"));
            knihovna.Add("978-0-521-85035-9", new Book("Madame Bovary", "Gustave Flaubert"));
            knihovna.Add("978-0-07-032450-3", new Book("The Count of Monte Cristo", "Alexandre Dumas"));
            knihovna.Add("978-0-13-110364-1", new Book("Don Quixote", "Miguel de Cervantes"));
            knihovna.Add("978-0-262-03386-2", new Book("The Picture of Dorian Gray", "Oscar Wilde"));
            knihovna.Add("978-0-471-48650-3", new Book("Frankenstein", "Mary Shelley"));
            knihovna.Add("978-0-387-98773-6", new Book("Dracula", "Bram Stoker"));
            knihovna.Add("978-0-521-85036-6", new Book("The Adventures of Sherlock Holmes", "Arthur Conan Doyle"));
            knihovna.Add("978-0-07-032451-0", new Book("The Lord of the Rings", "J.R.R. Tolkien"));
            knihovna.Add("978-0-13-110365-8", new Book("Harry Potter and the Philosopher's Stone", "J.K. Rowling"));
            knihovna.Add("978-0-262-03387-9", new Book("The Chronicles of Narnia", "C.S. Lewis"));
            knihovna.Add("978-0-471-48651-0", new Book("The Hunger Games", "Suzanne Collins"));
            knihovna.Add("978-0-387-98774-3", new Book("The Maze Runner", "James Dashner"));
            knihovna.Add("978-0-521-85037-3", new Book("Divergent", "Veronica Roth"));
            knihovna.Add("978-0-07-032452-7", new Book("The Fault in Our Stars", "John Green"));
            knihovna.Add("978-0-13-110366-5", new Book("The Book Thief", "Markus Zusak"));
            knihovna.Add("978-0-262-03388-6", new Book("Gone Girl", "Gillian Flynn"));
            knihovna.Add("978-0-471-48652-7", new Book("The Girl on the Train", "Paula Hawkins"));
            knihovna.Add("978-0-387-98775-0", new Book("The Da Vinci Code", "Dan Brown"));
            knihovna.Add("978-0-521-85038-0", new Book("Angels & Demons", "Dan Brown"));
            knihovna.Add("978-0-07-032453-4", new Book("Inferno", "Dan Brown"));
            knihovna.Add("978-0-13-110367-2", new Book("The Shining", "Stephen King"));
            knihovna.Add("978-0-262-03389-3", new Book("It", "Stephen King"));
            knihovna.Add("978-0-471-48653-4", new Book("The Stand", "Stephen King"));
            knihovna.Add("978-0-387-98776-7", new Book("Misery", "Stephen King"));
            knihovna.Add("978-0-521-85039-7", new Book("The Green Mile", "Stephen King"));
            knihovna.Add("978-0-07-032454-1", new Book("The Road", "Cormac McCarthy"));
            knihovna.Add("978-0-13-110368-9", new Book("No Country for Old Men", "Cormac McCarthy"));
            knihovna.Add("978-0-262-03390-9", new Book("Blood Meridian", "Cormac McCarthy"));
            knihovna.Add("978-0-471-48654-1", new Book("The Catcher in the Rye", "J.D. Salinger"));
            knihovna.Add("978-0-387-98777-4", new Book("The Grapes of Wrath", "John Steinbeck"));
            knihovna.Add("978-0-521-85040-3", new Book("Of Mice and Men", "John Steinbeck"));
            knihovna.Add("978-0-07-032455-8", new Book("East of Eden", "John Steinbeck"));
            string isbn = "";
            while (true)
            {
                Console.WriteLine("Vítej ve správě knihovny!\nPro vložení knihy zadej 1\nPro odebrání knihy zadej 2\nVyhledání knihy zadej 3\nVypis knihy zadej 4\nVypni program 5");
                int volba = int.Parse(Console.ReadLine());
                switch(volba)
                {
                    case 1:
                        knihovna = VlozKnihu(knihovna);
                        break;
                    case 2:
                        Console.WriteLine("Zadej ISBN");
                        isbn = Console.ReadLine();
                        if(knihovna.ContainsKey(isbn))
                        {
                            knihovna.Remove(isbn);
                        } else
                        {
                            Console.WriteLine("Takové ISBN není");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Zadej ISBN");
                        isbn = Console.ReadLine();
                        if (knihovna.ContainsKey(isbn))
                        {
                            knihovna.TryGetValue(isbn, out Book kniha);
                            Console.WriteLine(kniha.DisplayInfo());
                        }
                        else
                        {
                            Console.WriteLine("Takové ISBN není");
                        }
                        break;
                    case 4:
                        foreach(Book kniha in knihovna.Values)
                        {
                            Console.WriteLine(kniha.DisplayInfo());
                        }
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }

        }

        static Dictionary<string,Book> VlozKnihu(Dictionary<string,Book> knihovna)
        {
            Console.WriteLine("Vlož mi ISBN");
            string isbn = Console.ReadLine();
            Console.WriteLine("Vlož mi Název");
            string nazev = Console.ReadLine();
            Console.WriteLine("Vlož mi Autora");
            string autor = Console.ReadLine();
            knihovna.Add(isbn, new Book(nazev, autor));
            return knihovna;
        }
    }
}
