using System;

namespace ExercisesLesson41
{
    class Exercises3
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
                    Console.WriteLine(Sum(n));
                }
                else
                {
                    Console.WriteLine("INVALID");
                }
            }
        }

        static int Sum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
