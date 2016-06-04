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
            Vector<int> myVector1 = new Vector<int>(15, 18);
            Vector<int> myVector2 = new Vector<int>(21, 13);
          
            Console.WriteLine(myVector1 - myVector2);
            Console.WriteLine(myVector1 + myVector2);
            Console.WriteLine(myVector1.CompareTo(myVector2));
           
            
        }
    }
}
