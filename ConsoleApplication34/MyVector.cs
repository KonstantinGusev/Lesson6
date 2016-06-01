using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication34
{
    public class Vector<T> : IEnumerable<Vector<T>> where T : struct
    {
        private List<Vector<T>> myVector;
        public IEnumerator<Vector<T>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}