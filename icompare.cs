using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.enumrablepro
{
    public class icompare
    {
        static void Main(string[] args)
        {
            product keyboard = new product(200, "keyboard");
            product mouse  = new product(200, "mouse");

            int result = keyboard.CompareTo(mouse);
            if (result == 1)
            {
                Console.WriteLine("keyboard is more than mouse");
            }
            else if (result == -1)
            {
                Console.WriteLine("keyboard less than mouse");
            }
            else
            {
                Console.WriteLine("keyboard and mouse quantity is equal ");
            }

        }
    }
    //
    public class product : IComparable
    {
        private int price;
        private string  name;
        public product(int price, string name)
        {
            this.price = price;
            this.name = name;
        }

        public int CompareTo(object obj) 
        {

            // convert object to player class
            product p = (product)obj; 
        
            if (this.price > p.price)
            {
                return 1;
            }
            else if (this.price < p.price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{price} -> {name}";
        }
    }




}
