using System;

namespace ExercisesLesson41
{
    class Exercises9
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Test {test}: {(IsSymmetry(n) ? "YES" : "NO")}");
            }
        }

        /// <summary>
        /// Phương thức kiểm tra số n có thuận nghịch không.
        /// </summary>
        /// <param name="n">Số nguyên cần kiểm tra.</param>
        /// <returns>true nếu n thuận nghịch và false trong trường hợp ngược lại.</returns>
        static bool IsSymmetry(int n)
        {
            if (n < 0)
            {
                n = -n;
            }
            int reverse = 0;
            int m = n;
            while (m > 0)
            {
                reverse = reverse * 10 + m % 10;
                m /= 10;
            }
            return reverse == n;
        }
    }
}
