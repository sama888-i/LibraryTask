using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Library
    {
        

        Book[] Books = { };
        
        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length -1] = book;
        }
        public Book GetFilteredBooks(string Genre)
        {
            Book foundBooks = null;
            foreach (var book in Books)
            {  if(book.Genre == Genre)
                {

                     foundBooks = book;
                    return foundBooks;
                }
                

            }
            return foundBooks;
            
           

        }
        public Book[] GetFilteredBooks(double minPrice, double maxPrice)
        {

            Book[] foundBook = new Book[0];
            foreach (var book in Books)
            {   if (book.Price >= minPrice && book.Price <= maxPrice)
                {
                    Array.Resize(ref foundBook, foundBook .Length + 1);
                    foundBook[foundBook .Length - 1] = book;
                   
                    
                }
                

            }
            return foundBook;
            
            

        }
        public void ShowAllbooks()
        {
            foreach (var book in  Books)
            {
                book.ShowInfo();
            }
        }

    }
}
