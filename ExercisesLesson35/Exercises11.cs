using System;

namespace ExercisesLesson35
{
    class Exercises11
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine()); // đọc vào số bộ test
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Test {i}: "); // in ra thứ tự bộ test
                if (n < 0)
                {
                    Console.WriteLine("INVALID");
                }
                else
                {
                    int product = 1;
                    for (int k = n; k > 0; k /= 10)
                    {
                        product *= k % 10;
                    }
                    Console.WriteLine(product);
                }
            }
        }
    }
}
