/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.28
/// </summary>

using System;

namespace ExercisesLesson47
{
    class Exercises9
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Test {test}: {SumOf(n)}");
            }
        }

        // phương thức đệ quy tính tổng các số từ 1 đến n
        static int SumOf(int n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return n + SumOf(n - 1);
            }
        }
    }
}
