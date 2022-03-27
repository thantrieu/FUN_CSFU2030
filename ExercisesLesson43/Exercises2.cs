using System;

namespace ExercisesLesson43
{
    class Exercises2
    {
        static void Main()
        {
            // test với số nguyên int
            Console.WriteLine("Tim gia tri nho nhat trong cac so int: ");
            int a = 100;
            int b = 200;
            int c = 300;
            int d = 400;
            Console.WriteLine($"Min({a}, {b}) = {Min(a, b)}");
            Console.WriteLine($"Min({a}, {b}, {c}) = {Min(a, b, c)}");
            Console.WriteLine($"Min({a}, {b}, {c}, {d}) = {Min(a, b, c, d)}");

            // test với số thực float
            Console.WriteLine("Tim gia tri nho nhat trong cac so float: ");
            float i = 1.35f;
            float j = 2.55f;
            float k = 33.32f;
            float m = 4.78f;
            Console.WriteLine($"Min({i}, {j}) = {Min(i, j)}");
            Console.WriteLine($"Min({i}, {j}, {k}) = {Min(i, j, k)}");
            Console.WriteLine($"Min({i}, {j}, {k}, {m}) = {Min(i, j, k, m)}");

            // test với số thực double
            Console.WriteLine("Tim gia tri nho nhat trong cac so double: ");
            double d1 = 1.25;
            double d2 = 2.65;
            double d3 = 3.85;
            double d4 = 4.78;
            Console.WriteLine($"Min({d1}, {d2}) = {Min(d1, d2)}");
            Console.WriteLine($"Min({d1}, {d2}, {d3}) = {Min(d1, d2, d3)}");
            Console.WriteLine($"Min({d1}, {d2}, {d3}, {d4}) = {Min(d1, d2, d3, d4)}");
        }

        static int Min(int a, int b)
        {
            return a < b ? a : b;
        }

        static int Min(int a, int b, int c)
        {
            return Min(Min(a, b), c);
        }

        static int Min(int a, int b, int c, int d)
        {
            return Min(Min(a, b), c, d);
        }

        static float Min(float a, float b)
        {
            return a < b ? a : b;
        }

        static float Min(float a, float b, float c)
        {
            return Min(Min(a, b), c);
        }

        static float Min(float a, float b, float c, float d)
        {
            return Min(Min(a, b), c, d);
        }

        static double Min(double a, double b)
        {
            return a < b ? a : b;
        }

        static double Min(double a, double b, double c)
        {
            return Min(Min(a, b), c);
        }

        static double Min(double a, double b, double c, double d)
        {
            return Min(Min(a, b), c, d);
        }
    }
}
