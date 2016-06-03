using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication34 
{
    public class MathematicsVectors<T> : IComparable<Vector<T>> where T : struct
    {
        public MathematicsVectors
           (string vectorname,
            T oneVector,
            T twoVector)
         {
            this.vectorname = vectorname;
            this.oneVector = oneVector;
            this.twoVector = twoVector;
            
        }

        public T oneVector { get; private set; }
        public T twoVector { get; private set; }
        public string vectorname { get; private set; }
    
      public int CompareTo(Vector<T> other)
        {
            throw new NotImplementedException();
        }

        
    }
}