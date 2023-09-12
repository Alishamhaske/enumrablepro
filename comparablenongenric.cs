using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.enumrablepro
{
    internal class comparablenongenric
    {
        static void Main(string[] args)
        {
            employeeComp emp1 = new employeeComp { name = "alisha", salary = 80000 };
            employeeComp emp2 = new employeeComp { name = "tanu", salary = 789888 };
            CheckSalaray c = new CheckSalaray();
            int result = c.Compare(emp1, emp2);
            if (result == 1)
            {
                Console.WriteLine("emp salaray greater than emp2");
            }
            else if (result == -1)
            {
                Console.WriteLine("emp has less salary than emp2");
            }
            else
            {
                Console.WriteLine("emp1 and emp2  has equal salary");
            }

        }
    }    ///
    public class employeeComp
    {
        public string name { get; set; }
        public int salary{get; set;}
    }
    public class CheckSalaray : IComparer<employeeComp>

    {
        public int Compare(employeeComp x, employeeComp y)
        {
            if(x.salary > y.salary)
            {
                return 1;
            }
            else if(x.salary<y.salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
