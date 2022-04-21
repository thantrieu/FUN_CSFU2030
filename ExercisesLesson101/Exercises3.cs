///<summary>
///<author>Branium Academy</author>
///<version>2022.04.20</version>
///<see cref="Trang chủ" href="https://braniumacademy.net"/>
///</summary>

using System;
using System.Text;

namespace ExercisesLesson101
{
    internal class Exercises3
    {
        static void Main()
        {
            int a = 20;
            int b = 50;
            int c = 400;
            double d1 = 20.25;
            double d2 = 15.99;
            double d3 = 18.99;
            Console.WriteLine($"Min({a}, {b}, {c}) = {Min(a, b, c)}");
            Console.WriteLine($"Min({d1}, {d2}, {d3}) = {Min(d1, d2, d3)}");
        }

        // phương thức tìm giá trị nhỏ hơn trong 3 giá trị
        public static T Min<T>(T a, T b, T c) where T : IComparable<T>
        {
            T min = a; // giả định min là a
            if(min.CompareTo(b) > 0) // b là min
            {
                min = b; 
            }
            if(min.CompareTo(c) > 0) // c là min
            {
                min = c;
            }
            return min;
        }
    }
}
