/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.28
/// </summary>

using System;

namespace ExercisesLesson47
{
    class Exercises2
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n >= 0)
                {
                    Console.WriteLine($"Test {test}: {Fibonacci(n)}");
                }
                else
                {
                    Console.WriteLine($"Test {test}: ERROR");
                }
            }
        }

        // phương thức đệ quy tìm số fibonacci fn
        static decimal Fibonacci(int n)
        {
            if (n < 2)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
