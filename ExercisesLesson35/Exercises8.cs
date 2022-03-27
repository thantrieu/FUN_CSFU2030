using System;

namespace ExercisesLesson35
{
    class Exercises8
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine()); // đọc vào số bộ test
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.Write($"Test {i}: "); // in ra thứ tự bộ test
                bool isPrime = true;
                if (n < 2)
                {
                    isPrime = false;
                }
                else
                {
                    int bound = (int)Math.Sqrt(n);
                    for (int j = 2; j <= bound; j++)
                    {
                        if (n % j == 0)
                        {
                            isPrime = false;
                        }
                    }
                }
                Console.WriteLine(isPrime ? "YES" : "NO");
            }
        }
    }
}
