using System;

namespace ExercisesLesson35
{
    class Exercises9
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine()); // đọc vào số bộ test
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.Write($"Test {i}: "); // in ra thứ tự bộ test
                if (n < 0)
                {
                    n = -1 * n;
                }
                int reverse = 0;
                for (int value = n; value > 0; value /= 10)
                {
                    reverse = reverse * 10 + value % 10;
                }
                Console.WriteLine(reverse == n ? "YES" : "NO");
            }
        }
    }
}
