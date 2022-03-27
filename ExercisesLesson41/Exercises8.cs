using System;

namespace ExercisesLesson41
{
    class Exercises8
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Test {test}: {(IsPrime(n) ? "YES" : "NO")}");
            }
        }

        static bool IsPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            int bound = (int)Math.Sqrt(n);
            for (int i = 2; i <= bound; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
