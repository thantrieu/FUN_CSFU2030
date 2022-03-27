using System;

namespace ExercisesLesson41
{
    class Exercises12
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine($"Test {test}: INVALID");
                }
                else if (n > 139)
                {
                    Console.WriteLine($"Test {test}: OVERFLOW");
                }
                else
                {
                    Console.WriteLine($"Test {test}: {Fibonacci(n)}");
                }
            }
        }

        static decimal Fibonacci(int n)
        {
            decimal result = n < 2 ? n : 0;
            decimal f0 = 0;
            decimal f1 = 1;
            for (int i = 2; i <= n; i++)
            {
                result = f0 + f1;
                f0 = f1;
                f1 = result;
            }
            return result;
        }
    }
}
