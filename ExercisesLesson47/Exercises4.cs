/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.28
/// </summary>

using System;

namespace ExercisesLesson47
{
    class Exercises4
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Test {test}: {ReverseNumber(n)}");
            }
        }

        // phương thức đệ quy tìm số đảo ngược các chữ số của n
        static string ReverseNumber(int n)
        {
            if (n < 10)
            {
                return n + "";
            }
            else
            {
                return (n % 10) + "" + ReverseNumber(n / 10);
            }
        }
    }
}
