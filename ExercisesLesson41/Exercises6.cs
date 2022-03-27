using System;

namespace ExercisesLesson41
{
    class Exercises6
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Test {test}: ");
                if (n > 0 && n < 28)
                {
                    Console.WriteLine($"{Sum(n)}");
                }
                else
                {
                    Console.WriteLine("INVALID");
                }
            }
        }

        static decimal Sum(int n)
        {
            decimal result = 0;
            decimal factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                result += factorial;
            }
            return result;
        }
    }
}
