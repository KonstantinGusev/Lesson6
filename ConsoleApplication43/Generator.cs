using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication43
{
    //генератор
     class Generator<T> : IEnumerable<Vector<T>> where T : struct, IComparable
    {
        public IEnumerator<Vector<T>> GetEnumerator()
        {
            Random random = new Random();
            int y = 55;
            for (int i = 0; i < 10; i++)
            {
                yield return new Vector<T>( (dynamic)random.Next(1, 30), (dynamic)random.Next(1, 30));
                y++;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}