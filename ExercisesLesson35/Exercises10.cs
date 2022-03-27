using System;

namespace ExercisesLesson35
{
    class Exercises10
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
                    int sum = 0;
                    for (int k = n; k > 0; k /= 10)
                    {
                        sum += k % 10;
                    }
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
