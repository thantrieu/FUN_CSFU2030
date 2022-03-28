/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.28
/// </summary>

using System;

namespace ExercisesLesson47
{
    class Exercises6
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Test {test}: {FirstDigitOfNumber(n)}");
            }
        }

        // phương thức đệ quy tìm chữ số đầu tiên của số nguyên dương n
        static int FirstDigitOfNumber(int n)
        {
            if (n < 10)
            {
                return n;
            }
            else
            {
                return FirstDigitOfNumber(n / 10);
            }
        }
    }
}
