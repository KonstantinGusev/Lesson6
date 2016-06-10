using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication43
{


    class Program
    {

        static void Main(string[] args)
        {
            
            Vector<int> myVector1 = new Vector<int>(15,18);
            Vector<int> myVector2 = new Vector<int>(12, 13);
            var z= new Generator<int>();
            z.ToList();
            foreach (var q in z)
            {
                Console.WriteLine(q);
            }
            Console.WriteLine("");

            var sortedList = z.OrderBy(o => o.length).ToList();

            foreach (var s in sortedList)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("");
            Console.WriteLine(myVector1 - myVector2);
            Console.WriteLine(myVector1 + myVector2);
            Console.WriteLine(myVector1.CompareTo(myVector2));
            //Console.WriteLine();


        }
    }
}
