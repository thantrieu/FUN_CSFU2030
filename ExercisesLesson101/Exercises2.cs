using System.Threading.Tasks;


using System;

namespace ExercisesLesson101
{
    class Exercises2
    {
        static void Main()
        {
            int a = 20;
            int b = 50;
            int c = 400;
            double d1 = 20.25;
            double d2 = 15.99;
            Console.WriteLine($"Max({a}, {b}) = {Max(a, b)}");
            Console.WriteLine($"Max({d1}, {d2}) = {Max(d1, d2)}");
            Console.WriteLine($"Max({b}, {c}) = {Max(b, c)}");
        }

        // phương thức tìm giá trị lớn nhất trong 2 giá trị
        public static T Max<T>(T a, T b) where T : IComparable<T>
        {
            return (a.CompareTo(b) > 0) ? a : b;
        }
    }
}
