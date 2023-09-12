using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.enumrablepro
{
    public class enumbrable1
    {
        static void Main(string[] args)
        {
            team t1 = new team();
            foreach(player t in t1 )
            {
                Console.WriteLine(t);
            }
        }
    }
    ////
    ///
    public class player
    {
        private int runs;
        private string name;

        public player(int runs,string name)
        {
            this.runs = runs;
            this.name = name;
        }
        public override string ToString()
        {
            return $"{runs}:{name}";
        }

    }
    //
    public class team:IEnumerable
    {
        private player[] players;
        public team()
        {
            players=new player[4]
            
            {
                new player(5000, "Sachin"),
                new player(6000, "Sachin"),
                new player(7000, "Sachin"),
                new player(8000, "Sachin")

            };
        }
        public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();

        }

    }
}
