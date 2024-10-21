namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Book book1 = new Book(1, 25.5, "Ilahi Komediya",25, "Epic Poetry");
            Book book2 = new Book(2, 14.88, "Martin Eden",45, "Literary fiction");
            Book book3 = new Book(3, 20, "Sefiller" ,80, "Fiction");
            Book book4 = new Book(4, 48, "Narnia",100, "Fantasy");
            Book book5 = new Book(5, 48, "Harry Potter", 100, "Fantasy");
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);

             //library.GetFilteredBooks("Fantasy").ShowInfo();
            
            
            
            Book[] filteredbook = library.GetFilteredBooks(8, 25);                                         
            foreach (var book in filteredbook )
            {
                  book.ShowInfo();

            }
            
            

        }
    }
}
