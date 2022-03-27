using System;

namespace ExercisesLesson41
{
    class Exercises11
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
                else
                {
                    Console.WriteLine($"Test {test}: {ProductOfDigits(n)}");
                }
            }
        }

        static int ProductOfDigits(int n)
        {
            int product = 1;
            while (n > 0)
            {
                product *= n % 10;
                n /= 10;
            }
            return product;
        }
    }
}
