using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Book:Product 
    {
        public string Genre;


        public Book(int No, double price, string Name,int count,string Genre):base(No,price,Name,count)
        {
            this.Genre = Genre;
            
        }
        public void ShowInfo() 
        {
            Console.WriteLine($"No:{No},price:{Price},Name:{Name},Count:{Count};Genre:{Genre}");
        }


    }
}
