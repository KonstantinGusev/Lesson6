
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Program
    {

        static void Main(string[] args)
        {
            Vector vector1 = new Vector(2);
            vector1.Generic(vector1);

           

            vector1.Print();

            Vector vector2 = new Vector(2);
            vector2.Generic(vector2);

            vector2.Print();
            
            (vector1 + vector2).Print();
            (vector1 * 10).Print();

            Console.ReadLine();
        }
    }
}
