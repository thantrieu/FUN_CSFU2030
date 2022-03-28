/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.28
/// </summary>

using System;

namespace ExercisesLesson47
{
    class Exercises1
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                int n = int.Parse(Console.ReadLine());
                if(n >= 0)
                {
                    Console.WriteLine($"Test {test}: {Factorial(n)}");
                } else
                {
                    Console.WriteLine($"Test {test}: ERROR");
                }
            }
        }

        // phương thức đệ quy tính n!
        static decimal Factorial(int n)
        {
            if(n == 0 || n == 1)
            {
                return 1;
            } else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
