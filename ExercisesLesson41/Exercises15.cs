using System;

namespace ExercisesLesson41
{
    class Exercises15
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.Write($"Test {test}: ");
                if (n > 0)
                {
                    Console.WriteLine(SumDivisor(n) ? "YES" : "NO");
                }
                else
                {
                    Console.WriteLine("INVALID");
                }
            }
        }

        static bool SumDivisor(int n)
        {
            if(n < 6)
            {
                return false;
            }
            int sum = 1;
            int bound = (int)Math.Sqrt(n);
            for (int i = 2; i <= bound; i++)
            {
                if (n % i == 0)
                {
                    if (n / i == i)
                    {
                        sum += i;
                    }
                    else
                    {
                        sum += i;
                        sum += n / i;
                    }
                }
            }
            return sum == n;
        }
    }
}
