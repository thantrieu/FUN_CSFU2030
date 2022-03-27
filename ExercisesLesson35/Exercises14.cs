using System;

namespace ExercisesLesson35
{
    class Exercises14
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine()); // đọc vào số bộ test
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.Write($"Test {i}: "); // in ra thứ tự bộ test
                if (n <= 0)
                {
                    Console.WriteLine("INVALID");
                }
                else
                {
                    int count = 0;
                    int bound = (int)Math.Sqrt(n);
                    for (int k = 1; k <= bound; k++)
                    {
                        if(n % k == 0)
                        {
                            if (n / k == k)
                            {
                                count++;
                            }
                            else
                            {
                                count += 2;
                            }
                        }
                    }
                    Console.WriteLine(count);
                }
            }
        }
    }
}
