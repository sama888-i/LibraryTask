using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Product
    {
        public int No;        
        private double _price;
        public string Name;
        private int _count;

        public Product(int No, double price,string Name,int count)
        {
            this.No = No;
            this.Name = Name;
            Price = price;
            Count = count;
            
        }
        public double Price
        { 
            get
            {
                return _price;

            }
            set
            {
                if (value > 0)
                {

                    _price = value;
                }
            } 
        }
        public int Count 
        { get
            {
                return _count;
            }
            set
            {
                if (value > 0)
                {
                    _count = value;


                }
                                                 
            }
            
        }
    }
}
