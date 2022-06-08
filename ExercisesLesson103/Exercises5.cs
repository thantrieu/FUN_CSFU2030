///<summary>
///<author>Branium Academy</author>
///<seealso cref="Trang chủ" href="https://braniumacademy.net"/>
///<version>2022.06.08</version>
///</summary>

using System;

namespace ExercisesLesson103
{
    internal class Exercises5
    {
        public delegate T DoCalculateDelegate<T>(T a, T b, T c);

        static double Add(double a, double b, double c)
        {
            return a + b + c;
        }

        static double Sub(double a, double b, double c)
        {
            return a - b - c;
        }

        static double Mul(double a, double b, double c)
        {
            return a * b * c;
        }

        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        static int Sub(int a, int b, int c)
        {
            return a - b - c;
        }

        static int Mul(int a, int b, int c)
        {
            return a * b * c;
        }

        static void Main()
        {
            int a = 20;
            int b = 30;
            int c = 40;
            double x = 5.25;
            double y = 6.69;
            double z = 8.25;

            DoCalculateDelegate<double> doubleDel = Add;
            Console.WriteLine($"{x} + {y} + {z} = " + doubleDel(x, y, z));
            doubleDel = Sub;
            Console.WriteLine($"{x} - {y} - {z} = " + doubleDel(x, y, z));
            doubleDel = Mul;
            Console.WriteLine($"{x} * {y} * {z} = " + doubleDel(x, y, z));

            DoCalculateDelegate<int> intDel = Add;
            Console.WriteLine($"{a} + {b} + {c} = " + intDel(a, b, c));
            intDel = Sub;
            Console.WriteLine($"{a} - {b} - {c} = " + intDel(a, b, c));
            intDel = Mul;
            Console.WriteLine($"{a} * {b} * {c} = " + intDel(a, b, c));
        }
    }
}
