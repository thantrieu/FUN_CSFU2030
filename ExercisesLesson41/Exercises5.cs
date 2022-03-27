using System;

namespace ExercisesLesson41
{
    class Exercises5
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
                    Console.WriteLine($"{Sum(n):f5}");
                }
                else
                {
                    Console.WriteLine("INVALID");
                }
            }
        }

        static float Sum(int n)
        {
            float sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0f / (i * i);
            }
            return sum;
        }
    }
}
