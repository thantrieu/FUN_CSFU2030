using System;

namespace ExercisesLesson41
{
    class Exercises13
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Test {test}: ");
                if (n > 0)
                {
                    ListedDivisor(n);
                }
                else
                {
                    Console.WriteLine("INVALID");
                }
            }
        }

        static void ListedDivisor(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
    }
}
