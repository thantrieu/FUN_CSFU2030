using System;

namespace ExercisesLesson35
{
    class Exercises13
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine()); // đọc vào số bộ test
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Test {i}: "); // in ra thứ tự bộ test
                if (n <= 0)
                {
                    Console.WriteLine("INVALID");
                }
                else
                {
                    for (int k = 1; k <= n; k++)
                    {
                        if (n % k == 0)
                        {
                            Console.Write($"{k} ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
