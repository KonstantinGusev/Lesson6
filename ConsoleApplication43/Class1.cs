using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication43
{
    class Vector<T> where T:IComparable

    {
        public int X { get; set; }
        public int Y { get; set; }
        public double length { get; set; }

        public Vector (int xPos,int yPos)
        {
            this.X = xPos;
            this.Y = yPos;
            length = Math.Sqrt(Math.Pow((dynamic)xPos, 2) + Math.Pow((dynamic)yPos, 2));
        }

        public override string ToString()
        {
            return string.Format("[X={0}, Y={1} , Lenght={2}]", this.X,this.Y,this.length);
        }

        public int CompareTo(Vector<T> other)
        {
            if (this.length > other.length)
            { Console.WriteLine("Больше");
                return 1;
            }
            if (this.length < other.length)
            {
                Console.WriteLine("Меньше");
                return -1;
            }
            else
            {
                Console.WriteLine("Равны");
                return 0;
            }
        }

        public static bool operator <(Vector<T> v1,Vector<T> v2)
        {
            return (v1.CompareTo(v2) < 0);
        }

        public static bool operator >(Vector<T> v1,Vector<T> v2)
        {
            return (v1.CompareTo(v2) > 0);
        }

        public static bool operator <=(Vector<T> v1,Vector<T> v2)
        {
            return (v1.CompareTo(v2) <= 0);
        }

        public static bool operator >=(Vector<T> v1, Vector<T> v2)
        {
            return (v1.CompareTo(v2)>= 0);
        }

        public static Vector<T> operator+(Vector<T> v1,Vector<T> v2)
        {
            return new Vector<T>(v1.X + v2.X, v1.Y + v2.Y);
        }


        public static Vector<T> operator -(Vector<T> v1, Vector<T> v2)
        {
            return new Vector<T>(v1.X - v2.X, v1.Y - v2.Y);
        }


        public static void Sort(Vector<T> v3)
        {
            Sort(v3);
        }

    }
}
