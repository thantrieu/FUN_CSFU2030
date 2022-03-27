using System;

namespace ExercisesLesson41
{
    class Exercises14
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
                    Console.WriteLine(CountDivisor(n));
                }
                else
                {
                    Console.WriteLine("INVALID");
                }
            }
        }

        static int CountDivisor(int n)
        {
            int counter = 0;
            int bound = (int)Math.Sqrt(n);
            for (int i = 1; i <= bound; i++)
            {
                if (n % i == 0)
                {
                    if (n / i == i)
                    {
                        counter++;
                    }
                    else
                    {
                        counter += 2;
                    }
                }
            }
            return counter;
        }
    }
}
