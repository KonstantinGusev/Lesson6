using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Vector
    {
        public decimal[] vector;//поле
        static Random R = new Random(); // генератор случайных чисел//поле

        public Vector(int n)//конструктор
        {
            vector = new decimal[n];
        }

        public void SetElement(int n, decimal val)//метод
        {
            vector[n] = val;
        }

        public int Size()
        {
            return (this.vector.Length);
        }

         public void Print()
        {
            for (int i = 0; i < this.Size(); ++i)
            {
                Console.Write(this.vector[i] + " ");
            }
            Console.WriteLine();
        }

        
        


       ///public override string ToString()
       // {
       //     return string.Format("{0}" + " ", this.vector);
                                
       // }

        public static Vector operator +(Vector v1, Vector v2) //перегруженный оператор
        {
            Vector v3 = new Vector(v1.Size());
            for (int i = 0; i < v1.Size(); ++i)
            {
                v3.vector[i] = v1.vector[i] + v2.vector[i];
            }
            return v3;
        }

        //вычитание векторов
        public static Vector operator -(Vector v1, Vector v2) //перегруженный оператор
        {
            Vector v3 = new Vector(v1.Size());
            for (int i = 0; i < v1.Size(); ++i)
            {
                v3.vector[i] = v1.vector[i] - v2.vector[i];
            }
            return v3;
        }

        //умножение на скаляр
        public static Vector operator *(Vector v1, int scal) //перегруженный оператор
        {
            Vector v3 = new Vector(v1.Size());
            for (int i = 0; i < v1.Size(); ++i)
            {
                v3.vector[i] = v1.vector[i] * scal;
            }
            return v3;
        }

        public void Input(Vector v1)//метод ввода с клавиатуры
        { 
            Vector v3 = new Vector(v1.Size());
            for (int i = 0; i < v1.Size(); i++)
            {
                Console.Write("vector[" + i + "]=");
                v3.vector[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        //генератор векторов
        public void Generic(Vector v1)
        {
            Vector v3 = new Vector(v1.Size());
            for (int i = 1; i < v1.Size(); i++)
            {
                v3.vector[i] = R.Next(1, 9);
            }
        }
    }
}
