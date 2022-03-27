using System;

namespace ExercisesLesson45
{
    class Exercises5
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Test {test}: {BeautyNumbers(n)}");
            }
        }

        /// <summary>
        /// Phương thức kết luận số nguyên n có phải số đẹp không.
        /// </summary>
        /// <param name="n">Số nguyên cần kiểm tra.</param>
        /// <returns>YES nếu n là số đẹp và NO nếu ngược lại.</returns>
        static string BeautyNumbers(int n)
        {
            if (n < 0)
            {
                n = -n;
            }
            return IsBeauty(n) ? "YES" : "NO";

            bool IsBeauty(int m)
            {
                int reverse = 0;
                while(m > 0)
                {
                    reverse = reverse * 10 + m % 10;
                    m /= 10;
                }
                return reverse == n;
            }
        }
    }
}
