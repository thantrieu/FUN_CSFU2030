/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.28
/// </summary>

using System;

namespace ExercisesLesson47
{
    class Exercises10
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Test {test}: {SumOf(n):0.000}");
            }
        }

        // phương thức đệ quy tính tổng 1/k các số k từ 1 đến n
        static double SumOf(int n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return 1.0 / n + SumOf(n - 1);
            }
        }
    }
}
