using System;

namespace ExercisesLesson35
{
    class Exercises12
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine()); // đọc vào số bộ test
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.Write($"Test {i}: "); // in ra thứ tự bộ test
                if (n < 0)
                {
                    Console.WriteLine("INVALID");
                }
                else
                {
                    decimal f0 = 0;
                    decimal f1 = 1;
                    decimal fn = n;
                    for (int k = 2; k <= n; k++)
                    {
                        fn = f0 + f1;
                        f0 = f1;
                        f1 = fn;
                    }
                    Console.WriteLine(fn);
                }
            }
        }
    }
}
