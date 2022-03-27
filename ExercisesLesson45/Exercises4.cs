using System;

namespace ExercisesLesson45
{
    class Exercises4
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Test {test}: {PerfectNumber(n)}");
            }
        }

        /// <summary>
        /// Phương thức kiểm tra số nguyên n có phải số hoàn hảo không.
        /// </summary>
        /// <param name="n">Số nguyên cần kiểm tra.</param>
        /// <returns>YES nếu n là số hoàn hảo và NO nếu ngược lại.</returns>
        static string PerfectNumber(int n)
        {
            if(n < 6)
            {
                return "NO";
            } else
            {
                return IsPerfect(n) ? "YES" : "NO";
            }

            bool IsPerfect(int m)
            {
                int sum = 1;
                int bound = (int)Math.Sqrt(m);
                for (int i = 2; i <= bound; i++)
                {
                    if(m % i == 0)
                    {
                        if(m / i != i)
                        {
                            sum += i;
                            sum += m / i;
                        } else
                        {
                            sum += i;
                        }
                    }
                }
                return m == sum;
            }
        }
    }
}
