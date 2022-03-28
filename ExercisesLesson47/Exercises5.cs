/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.28
/// </summary>

using System;

namespace ExercisesLesson47
{
    class Exercises5
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Test {test}: {CountDigits(n)}");
            }
        }

        // phương thức đệ quy đếm số lượng các chữ số của n
        static int CountDigits(int n)
        {
            if (n < 10)
            {
                return 1;
            }
            else
            {
                return 1 + CountDigits(n / 10);
            }
        }
    }
}
